using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms
{
    internal class Fibonacci
    {
        static Dictionary<int, int> fibResults = new Dictionary<int, int>();
        static int fibCount = 1;

        public static int FibIterative(int n)
        {
            int result = 0;
            int t0 = 0, t1 = 1;
            
            if (n <= 1)
                return n;

            for (int i = 2; i <= n; i++)
            {
#if DEBUG
                Console.WriteLine("Iteration : " + fibCount++);
#endif
                result = t0 + t1;
                t0 = t1;
                t1 = result;
            }
            return result;
        }
        public static int FibExcessiveRecursion(int n)
        {
#if DEBUG
            Console.WriteLine("Call : " + fibCount++);
#endif

            if (n <= 1)
            {
                return n;
            }

            return FibExcessiveRecursion(n - 2) + FibExcessiveRecursion(n - 1);
        }

        public static int FibOptimizedRecursionUsingMemoization(int n)
        {
            #if DEBUG
            Console.WriteLine("Call : " + fibCount++);
            #endif

            if (n <= 1)
            {
                fibResults.Add(n, n);
                return n;
            }

            var fib1Result = !fibResults.ContainsKey(n - 2) ? FibOptimizedRecursionUsingMemoization(n - 2) : fibResults[n - 2];
            var fib2Result = !fibResults.ContainsKey(n - 1) ? FibOptimizedRecursionUsingMemoization(n - 1) : fibResults[n - 1];

            var fibResult = fib1Result + fib2Result;
            fibResults.Add(n, fibResult);

            return fibResult;
        }
    }
}
