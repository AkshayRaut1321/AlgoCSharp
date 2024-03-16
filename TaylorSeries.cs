using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCSharp
{
    internal class TaylorSeries
    {
        static int p = 1, f = 1;
        public static long TaylorMaclaurin(int x, int n)
        {
            long result = 0;
            if (n == 0)
                return 1;

            result = TaylorMaclaurin(x, n - 1);
            p = p * x;
            f = f * n;
            return result + p / f;
        }

        public static (int, int, int) TaylorMaclaurinMultiReturn(int x, int n, int power, int fact)
        {
            int result = 0;
            if (n == 0)
                return (1, power, fact);

            (result, power, fact) = TaylorMaclaurinMultiReturn(x, n - 1, power, fact);
            power = power * x;
            fact = fact * n;
            return (result + (power / fact), power, fact);
        }
    }
}
