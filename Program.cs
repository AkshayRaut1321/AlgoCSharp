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
            PowerFunction.PowerOptimized(2, 9);

            Console.Read();
        }
    }
}
