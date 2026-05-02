using System.Collections.Generic;
using System.Linq;

namespace AlgoCSharp.LeetCodeProblems
{
    internal class WordFrequencies
    {
        internal List<(string, int)> GetAlphabeticalFrequencies(string text)
        {
            var wordsCount = new Dictionary<string, int>();
            var words = text.Split(' ');
            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                    wordsCount[word]++;
                else
                    wordsCount[word] = 1;
            }
            return wordsCount.Select(a => (a.Key, a.Value)).ToList();
        }
    }
}
