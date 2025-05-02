namespace AlgoCSharp.Algorithms.String
{
    public class StringNeedleHaystack
    {
        public int FindFirstOccurrenceOfString(string haystack, string needle)
        {
            if (haystack == null || needle == null || haystack.Length == 0 || needle.Length == 0 || needle.Length > haystack.Length)
                return -1;

            if (haystack == needle)
                return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;
                for (; j < needle.Length; j++)
                {
                    if (needle[j] != haystack[j + i])
                    {
                        j = -1;
                        break;
                    }
                }

                if (j == needle.Length)
                    return i;
            }
            return -1;
        }
    }
}
