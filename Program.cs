using AlgoCSharp.Algorithms;
using AlgoCSharp.Algorithms.BinaryTree;
using System;

namespace AlgoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTreeExample.Run();
            var sedolChecker = new SEDOLChecker();
            sedolChecker.Test();

            Console.Read();
        }
    }
}
