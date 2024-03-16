namespace AlgoCSharp.Algorithms
{
    internal class PowerFunction
    {
        public static long PowerBruteForce(int x, int n)
        {
            if (n == 0)
                return 1;

            return PowerBruteForce(x, n);
        }
        public static long PowerOptimized(int x, int n)
        {
            if (n == 0)
                return 1;

            if (n % 2 == 0)
                return PowerOptimized(x * x, n / 2);
            else
                return x * PowerOptimized(x * x, (n - 1) / 2);
        }
    }
}
