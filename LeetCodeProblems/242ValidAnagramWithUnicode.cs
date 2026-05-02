using System.Collections.Generic;

namespace AlgoCSharp.LeetCodeProblems
{
    internal class _242ValidAnagramWithUnicode
    {
        public bool IsAnagramUnicode(string s, string t)
        {
            //If they are of different lengths
            if (s.Length != t.Length)
                return false;

            //Proceed if lengths are same.
            var map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!map.ContainsKey(c))
                    map[c] = 0; //Initialize and then immediately increment thus starting with count 1.
                map[c]++;
            }

            foreach (char c in t)
            {
                if (!map.ContainsKey(c))
                    return false;   //If letter of string2 is not present in string1.

                map[c]--;
                if (map[c] < 0)
                    return false;   //If letter of string1 is not present in string2.
            }

            return true;
        }
    }
}
