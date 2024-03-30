namespace AlgoCSharp.Algorithms
{
    internal class CombinationPermutation
    {
        public static int nCrWithFactorialRecursion(int n, int r)
        {
            int nFact, rFact, nrFact;
            nFact = fact(n);
            rFact = fact(r);
            nrFact = fact(n - r);
            return nFact / (rFact * nrFact);
        }

        public static int fact(int number)
        {
            if (number == 0)
                return 1;

            return number * fact(number - 1);
        }

        public static int nCrWithPascalTriangeRecursion(int n, int r)
        {
            if (r == 0 || r == n)
                return 1;

            return nCrWithPascalTriangeRecursion(n - 1, r - 1) + nCrWithPascalTriangeRecursion(n - 1, r);
        }
    }
}
