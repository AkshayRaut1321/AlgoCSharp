using System;

namespace AlgoCSharp.Algorithms
{
    internal class TowerOfHanoi
    {
        public static void Move(int n, string from, string with, string to)
        {
            if (n > 0)
            {
                Move(n - 1, from, to, with);
                Console.WriteLine($"Moving {n} from {from} to {to}");
                Move(n - 1, with, from, to);
            }
        }
    }
}
