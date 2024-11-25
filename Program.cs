using AlgoCSharp.Algorithms;
using AlgoCSharp.Algorithms.Array;
using AlgoCSharp.Algorithms.ArrayADT;
using AlgoCSharp.Algorithms.Multithreading;
using System;
using System.Threading.Tasks;

namespace AlgoCSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Input: ");
            //BinaryTreeExample.Run();

            //var sedolChecker = new SEDOLChecker();
            //sedolChecker.Test();

            //PowerFunction.PowerBruteForce(2, 9);
            //PowerFunction.PowerOptimized(2, 9);

            //Console.WriteLine(TaylorSeries.TaylorMaclaurin(10, 3));
            //var result = TaylorSeries.TaylorMaclaurinMultiReturn(10, 3, 1, 1);
            //Console.WriteLine("Result : " + result.Item1);

            //Console.WriteLine("Result : " + Fibonacci.FibIterative(int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + Fibonacci.FibExcessiveRecursion(int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + Fibonacci.FibOptimizedRecursionUsingMemoization(int.Parse(Console.ReadLine())));

            //Console.WriteLine("Result : " + CombinationPermutation.nCrWithFactorialRecursion(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + CombinationPermutation.nCrWithPascalTriangeRecursion(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            //Console.WriteLine("Tower of Hanoi: ");
            //TowerOfHanoi.TOH(2, "A", "B", "C");
            //Console.WriteLine("Result quiz: " + f(1));

            //SortedArrayADT.FindMissingNumbers(new int[] { 6, 7, 8, 9, 11, 14, 16, 17 });

            //TaskParallelism.ParallelForWithException();
            //TaskParallelism.CombineResultFromTasks();
            //TaskParallelism.ParalleWithCancel();
            //TaskParallelism.TaskWait();

            //RemoveInPlaceElement.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            ArrayADT arrayADT = new ArrayADT();
            arrayADT.Start();

            Console.WriteLine("Enter the number to append");
            int newItem = Convert.ToInt32(Console.ReadLine());
            arrayADT.Append(newItem);

            arrayADT.Display();

            Console.WriteLine("Enter the number to insert");
            newItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position to insert the number");
            var insertAt = Convert.ToInt32(Console.ReadLine());

            arrayADT.Insert(newItem, insertAt);

            arrayADT.Display();

            Console.Read();
        }

        static int i = 1;

        static int f(int n)
        {
            if (n >= 5)
                return n;

            n = n + i;
            i++;
            return f(n);
        }
    }
}
