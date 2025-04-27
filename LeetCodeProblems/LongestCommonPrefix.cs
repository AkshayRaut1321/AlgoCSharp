using System.Collections.Generic;
using System.Text;

namespace AlgoCSharp.Algorithms
{
    public class LongestCommonPrefix
    {
        public string RunSorted(params string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            // Sort the array
            System.Array.Sort(strs);

            // Compare only the first and last words in the sorted array
            string first = strs[0];
            string last = strs[strs.Length - 1];
            int i = 0;

            // Find the common prefix between first and last words
            while (i < first.Length && i < last.Length && first[i] == last[i])
            {
                i++;
            }

            return first.Substring(0, i);
        }

        public string RunBruteForce(string[] strs)
        {
            string finalPrefix = "";

            if (strs == null || strs.Length == 0 || strs[0].Length == 0)
                return finalPrefix;

            if (strs.Length == 1)
                return strs[0];

            string keyString = strs[0];

            var prefixCount = new Dictionary<string, int>();

            for (int i = 1; i < strs.Length; i++)
            {
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (j < keyString.Length && keyString[j] == strs[i][j])
                    {
                        var charPos = keyString[j].ToString() + "," + j.ToString();
                        if (prefixCount.ContainsKey(charPos))
                        {
                            prefixCount[charPos]++;
                        }
                        else
                        {
                            prefixCount[charPos] = 2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            var prefix = new StringBuilder("");
            foreach (var keyValuePair in prefixCount)
            {
                if (keyValuePair.Value == strs.Length)
                {
                    var separatorPosition = keyValuePair.Key.IndexOf(",");
                    prefix.Append(keyValuePair.Key.Substring(0, separatorPosition));
                }
            }
            return prefix.ToString();
        }

        public string RunPrefixShrinking(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            // Start with the first word as the prefix
            string prefix = strs[0];

            // Compare the prefix with each word in the array
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // Shorten the prefix
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If prefix becomes empty, return ""
                    if (prefix == "")
                        return "";
                }
            }

            return prefix;
        }
    }
}
