namespace AlgoCSharp.Algorithms
{
    public class NumberPalindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
                return false;

            if (x == 0)
                return true;

            int copy = x;
            int reverse = 0;

            while (copy != 0)
            {
                reverse = (reverse * 10) + copy % 10;
                copy = copy / 10;
            }

            return reverse == x;
        }

        public bool IsPalindromeReverseOnlyHalf(int original)
        {
            if (original < 0 || (original != 0 && original % 10 == 0))
                return false;

            int reverseHalf = 0;

            while (original > reverseHalf)
            {
                reverseHalf = (reverseHalf * 10) + original % 10;
                original = original / 10;
            }

            return original == reverseHalf  || original == reverseHalf / 10;
        }

        public bool IsPalindromeAsString(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
                return false;

            var xCharArray = x.ToString();

            for (int i = 0, j = xCharArray.Length - 1; i < xCharArray.Length; i++, j--)
            {
                if (xCharArray[i] != xCharArray[j])
                    return false;
            }
            return true;
        }
    }
}
