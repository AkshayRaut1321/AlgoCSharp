using System.Collections.Generic;

namespace AlgoCSharp.Algorithms
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romans = new Dictionary<char, int>();
            romans['I'] = 1;
            romans['V'] = 5;
            romans['X'] = 10;
            romans['L'] = 50;
            romans['C'] = 100;
            romans['D'] = 500;
            romans['M'] = 1000;

            int final = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 1) < s.Length && romans[s[i]] < romans[s[i + 1]])
                    final = final - (romans[s[i]]);
                else
                    final = final + romans[s[i]];
            }

            return final;
        }
    }
}
