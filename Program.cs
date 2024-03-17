using AlgoCSharp.Algorithms;
using System;

namespace AlgoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTreeExample.Run();

            //var sedolChecker = new SEDOLChecker();
            //sedolChecker.Test();

            //PowerFunction.PowerBruteForce(2, 9);
            //PowerFunction.PowerOptimized(2, 9);

            //Console.WriteLine(TaylorSeries.TaylorMaclaurin(10, 3));
            //var result = TaylorSeries.TaylorMaclaurinMultiReturn(10, 3, 1, 1);
            //Console.WriteLine("Result : " + result.Item1);

            Console.WriteLine("Result : " + Fibonacci.FibIterative(int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + Fibonacci.FibExcessive(int.Parse(Console.ReadLine())));
            //Console.WriteLine("Result : " + Fibonacci.FibOptimizedRecursionUsingMemoization(int.Parse(Console.ReadLine())));

            Console.Read();
        }
    }
}
