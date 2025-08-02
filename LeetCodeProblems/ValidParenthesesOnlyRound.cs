using AlgoCSharp.Algorithms.StackADT;

namespace AlgoCSharp.LeetCodeProblems
{
    public class ValidParenthesesOnlyRound
    {
        public bool IsValid(string text)
        {
            StackArrayADT<char> stackArrayADT = new StackArrayADT<char>(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                    stackArrayADT.Push(text[i]);
                else if (text[i] == ')')
                {
                    if (stackArrayADT.IsEmpty)
                        return false;
                    stackArrayADT.Pop();
                }
            }

            return stackArrayADT.IsEmpty;
        }
    }
}
