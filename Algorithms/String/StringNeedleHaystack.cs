using System;

namespace AlgoCSharp.Algorithms.String
{
    public class StringNeedleHaystack
    {
        // Prime number to reduce hash collisions
        static int prime = 101;

        // Base for character values (e.g., number of characters in input alphabet)
        static int baseVal = 256;

        // Rabin-Karp search function
        public int RabinKarpSearch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            if (m > n)
            {
                Console.WriteLine("Pattern is longer than text. No match.");
                return -1;
            }

            long patternHash = 0;  // hash of pattern
            long textHash = 0;     // hash of current window in text
            long h = 1;            // base^(m-1) % prime

            // Precompute h = base^(m-1) % prime
            for (int i = 0; i < m - 1; i++)
                h = (h * baseVal) % prime;

            // Calculate initial hash for pattern and first window of text
            for (int i = 0; i < m; i++)
            {
                patternHash = (baseVal * patternHash + pattern[i]) % prime;
                textHash = (baseVal * textHash + text[i]) % prime;
            }

            // Slide the pattern over text one by one
            for (int i = 0; i <= n - m; i++)
            {
                // If hash values match, check characters one by one
                if (patternHash == textHash)
                {
                    bool match = true;
                    for (int j = 0; j < m; j++)
                    {
                        if (text[i + j] != pattern[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                        return i;
                }

                // Calculate hash for next window: remove leading char, add trailing char
                if (i < n - m)
                {
                    textHash = (baseVal * (textHash - text[i] * h) + text[i + m]) % prime;

                    // We might get negative value of textHash, convert it to positive
                    if (textHash < 0)
                        textHash += prime;
                }
            }

            return -1;
        }

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

        public int KMPStringIndexSearch(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;

            // Step 1: Build LPS array
            int[] lps = BuildLPS(needle);

            int i = 0; // pointer for haystack
            int j = 0; // pointer for needle

            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                    if (j == needle.Length)
                        return i - j; // Full match
                }
                else
                {
                    if (j != 0)
                    {
                        j = lps[j - 1]; // use prefix info to skip
                    }
                    else
                    {
                        i++; // no prefix to fall back on, just move
                    }
                }
            }

            return -1; // no match
        }

        private int[] BuildLPS(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int len = 0; // length of the previous longest prefix suffix
            int i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1]; // fallback
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }
    }
}
