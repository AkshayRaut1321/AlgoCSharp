namespace AlgoCSharp.Algorithms
{
    public class LongestCommonPrefix
    {
        public string Run(params string[] strs)
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
    }

}
