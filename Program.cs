using AlgoCSharp.Algorithms;
using System;

namespace AlgoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
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
            //TowerOfHanoi.Move(3, "A", "B", "C");
            Console.WriteLine("Result quiz: " + f(1));

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
