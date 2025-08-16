using System;

namespace AlgoCSharp.Algorithms.StackADT
{
    public class InfixPostfixConversion
    {
        public string ConvertOptimized(string expression)
        {
            StackArrayADT<char> stack = new StackArrayADT<char>(expression.Length);
            string postfix = string.Empty;
            int i = 0;
            while (i < expression.Length)
            {
                if (IsOperand(expression[i]))
                    postfix = postfix + expression[i++];
                else
                {
                    if (GetPrecedence(expression[i]) > GetPrecedence(stack.StackTop))
                        stack.Push(expression[i++]);
                    else
                        postfix = postfix + stack.Pop();
                }
            }
            //Add remaining operators
            while (!stack.IsEmpty)
            {
                char topChar = stack.Pop();
                postfix = postfix + topChar;
            }
            return postfix;
        }

        public string ConvertBruteForce(string expression)
        {
            string postfix = string.Empty;
            StackArrayADT<char> stack = new StackArrayADT<char>(expression.Length);

            //Iterate till last character.
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOperand(expression[i]))
                    postfix = postfix + expression[i];
                else
                {
                    int currentPrecedence = GetPrecedence(expression[i]);
                    if (!stack.IsEmpty)
                    {
                        while (GetPrecedence(stack.StackTop) >= currentPrecedence)
                        {
                            char topChar = stack.Pop();
                            postfix = postfix + topChar;
                        }
                        stack.Push(expression[i]);
                    }
                    else
                        stack.Push(expression[i]);
                }
            }

            //Add remaining operators
            while (!stack.IsEmpty)
            {
                char topChar = stack.Pop();
                postfix = postfix + topChar;
            }
            return postfix;
        }

        public bool IsOperand(char character)
        {
            if (character == '+' || character == '-' || character == '*' || character == '/')
                return false;
            return true;
        }

        public int GetPrecedence(char opr)
        {
            if (opr == '+' || opr == '-')
                return 1;
            else if (opr == '*' || opr == '/')
                return 2;
            return 0;
        }

        public string ConvertForParenthesized(string expression)
        {
            StackArrayADT<char> stack = new StackArrayADT<char>(expression.Length);
            string postfix = string.Empty;
            int i = 0;
            while (i < expression.Length)
            {
                char character = expression[i];
                if (IsOperandParenthsized(character))
                {
                    postfix = postfix + character;
                    i++;
                }
                else
                {
                    if (GetPrecedenceParenthsized(character, true)
                        > GetPrecedenceParenthsized(stack.StackTop, false)
                        && character != ')')
                    {
                        stack.Push(character);
                        i++;
                    }
                    else
                    {
                        char poppedChar = stack.Pop();
                        if (poppedChar != '(')
                        {
                            postfix = postfix + poppedChar;
                        }
                        else
                            i++;
                    }
                }
            }

            //Add remaining operators
            while (!stack.IsEmpty)
            {
                char topChar = stack.Pop();
                postfix = postfix + topChar;
            }
            return postfix;
        }

        public bool IsOperandParenthsized(char character)
        {
            if (character == '+' || character == '-' || character == '*'
                || character == '/' || character == '('
                || character == ')' || character == '^')
                return false;
            return true;
        }

        public int GetPrecedenceParenthsized(char opr, bool isOut)
        {
            if (opr == '+' || opr == '-')
                return isOut ? 1 : 2;
            else if (opr == '*' || opr == '/')
                return isOut ? 3 : 4;
            else if (opr == '^')
                return isOut ? 6 : 5;
            else if (opr == '(')
                return isOut ? 7 : 0;
            return 0;
        }

        public double EvaluateParenthesizedExpression(string postFixExpression)
        {
            StackArrayADT<string> stack = new StackArrayADT<string>(postFixExpression.Length);

            for (int i = 0; i < postFixExpression.Length; i++)
            {
                char character = postFixExpression[i];
                if (IsOperandParenthsized(character))
                {
                    stack.Push(character.ToString());
                }
                else
                {
                    string rightOpd = stack.Pop();
                    string leftOpd = stack.Pop();
                    var currentResult = EvaluateExpression(leftOpd, character, rightOpd);
                    stack.Push(currentResult.ToString());
                }
            }
            return Convert.ToDouble(stack.StackTop);
        }

        private double EvaluateExpression(string leftOpd, char oprt, string rightOpd)
        {
            double result = 0;

            switch (oprt)
            {
                case '+':
                    return Convert.ToInt32(leftOpd) + Convert.ToInt32(rightOpd);
                case '-':
                    return Convert.ToInt32(leftOpd) - Convert.ToInt32(rightOpd);
                case '/':
                    return Convert.ToInt32(leftOpd) / Convert.ToInt32(rightOpd);
                case '*':
                    return Convert.ToInt32(leftOpd) * Convert.ToInt32(rightOpd);
                case '^':
                    return Math.Pow(Convert.ToDouble(leftOpd), Convert.ToDouble(rightOpd));
                default:
                    break;
            }

            return result;
        }
    }
}
