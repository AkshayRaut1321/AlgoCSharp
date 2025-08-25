using System;

namespace AlgoCSharp.Algorithms
{
    internal class TowerOfHanoi
    {
        public static void TOH(int n, string from, string with, string to)
        {
            if (n > 0)
            {
                TOH(n - 1, from, to, with);
                Console.WriteLine($"Moving {n} from {from} to {to}");
                TOH(n - 1, with, from, to);
            }
            Console.WriteLine("Called");
        }
    }
}
