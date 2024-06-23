using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoCSharp.Algorithms.Multithreading
{
    internal class TaskParallelism
    {
        internal static void ParallelForWithException()
        {
            var result = Parallel.For(0, 10, (i) =>
            {
                if (i == 0)
                    throw new ApplicationException("First");
                if (i == 8)
                    throw new ApplicationException("Last");
            });
        }

        internal static void CombineResultFromTasks()
        {
            int[] nums = Enumerable.Range(0, 11).ToArray();
            long total = 0;
            Parallel.ForEach<int, long>(nums, () => 0, (j, loop, subtotal) => // method invoked by the loop on each iteration
            {
                subtotal += j; //modify local variable
                return subtotal; // value to be passed to next iteration
            },
            // Method to be executed when each partition has completed.
            // finalResult is the final value of subtotal for a particular partition.
            (finalResult) => Interlocked.Add(ref total, finalResult));

            Console.WriteLine("The total from Parallel.ForEach is {0:N0}", total);
        }

        internal static void ParalleWithCancel()
        {
            int[] nums = Enumerable.Range(0, 10000).ToArray();
            CancellationTokenSource cts = new CancellationTokenSource();

            // Use ParallelOptions instance to store the CancellationToken
            ParallelOptions options = new ParallelOptions()
            {
                CancellationToken = cts.Token,
                MaxDegreeOfParallelism = Environment.ProcessorCount
            };
            Console.WriteLine("Press any key to start. Press 'c' to cancel.");
            Console.ReadKey();

            // Run a task so that we can cancel from another thread.
            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar is 'c')
                {
                    cts.Cancel();
                    Console.WriteLine("press any key to exit");
                }
            });

            try
            {
                Parallel.ForEach(nums, options, (num) =>
                {
                    Console.WriteLine("{0} on {1}", num, Environment.CurrentManagedThreadId);
                });
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cts.Dispose();
            }

            Console.ReadKey();
        }

        internal static void TaskWait()
        {
            Task myTask = Task.Run(() =>
            {
                // Simulate work by sleeping for 2 seconds
                Thread.Sleep(2000);
                Console.WriteLine("Task completed.");
            });

            Console.WriteLine("Waiting for the task to complete.");
            myTask.Wait();  // Blocks the calling thread until myTask completes.
            Console.WriteLine("Task has completed. Continuing with other work.");
        }
    }
}
