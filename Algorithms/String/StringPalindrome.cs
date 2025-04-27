namespace AlgoCSharp.Algorithms.String
{
    public class StringPalindrome
    {
        //Program to check palindrome of a string
        public bool IsPalindromeSimple(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s[0] != s[s.Length - 1])
                return false;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }

            return true;
        }

        //Program to check palindrome of a string
        public bool IsPalindromeOnlyAlphaNumeric(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            s = s.ToLower();
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                var leftIsLetterOrDigit = char.IsLetterOrDigit(s[i]);

                var rightIsLetterOrDigit = char.IsLetterOrDigit(s[j]);

                if (leftIsLetterOrDigit && rightIsLetterOrDigit)
                {
                    if (s[i] != s[j])
                        return false;
                    i++;
                    j--;
                }
                else
                {
                    if (!leftIsLetterOrDigit)
                    {
                        i++;
                    }
                    if (!rightIsLetterOrDigit)
                    {
                        j--;
                    }
                }
            }
            return true;
        }
    }
}
