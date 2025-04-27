using System.Collections.Generic;
using System.Text;

namespace AlgoCSharp.LeetCodeProblems
{
    public class ValidParentheses
    {
        public bool IsValidChatGPT(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false; // Nothing to match
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0; // All brackets matched
        }

        public bool IsValidAkshay(string s)
        {
            var bracketScopes = new Dictionary<char, char>();
            bracketScopes.Add('(', 'O');
            bracketScopes.Add('{', 'O');
            bracketScopes.Add('[', 'O');
            bracketScopes.Add(')', 'C');
            bracketScopes.Add('}', 'C');
            bracketScopes.Add(']', 'C');

            var bracketRelations = new Dictionary<char, char>();
            bracketRelations.Add(')', '(');
            bracketRelations.Add('}', '{');
            bracketRelations.Add(']', '[');

            var stringBuilder = new StringBuilder("");

            if (s.Length == 0 || s.Length % 2 != 0 || bracketScopes[s[0]] == 'C')
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (bracketScopes[s[i]] == 'O')
                {
                    stringBuilder.Append(s[i]);
                }
                else
                {
                    if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == bracketRelations[s[i]])
                        stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    else
                        return false;
                }
            }

            return stringBuilder.Length > 0 ? false : true;
        }
    }
}
