using System;
using System.Linq;
using System.Text;

namespace AlgoCSharp.WarmupProblems
{
    internal class PatternPrinting
    {
        public void StarSquare(int size)
        {
            string row = string.Join(" ", Enumerable.Repeat("*", size));

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(row);
            }
        }

        public void StarPyramid(int size)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append("* ");
                Console.WriteLine(stringBuilder);
            }
        }

        public void NumberSequencePyramid(int size)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= size; i++)
            {
                stringBuilder.Append(i + " ");
                Console.WriteLine(stringBuilder);
            }
        }

        public void NumberRepeatPyramid(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void ReverseStarPyramid(int size)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append("*");
            }
            for (int i = size; i > 0; i--)
            {
                Console.WriteLine(stringBuilder);
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }
        }

        public void ReverseNumberSequencePyramid(int size)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= size; i++)
            {
                stringBuilder.Append(i + " ");
            }
            for (int i = size; i > 0; i--)
            {
                Console.WriteLine(stringBuilder);
                stringBuilder.Remove(stringBuilder.Length - 2, 2);
            }
        }

        public void StarPyramidFromCentre(int size)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= size; i++)
            {
                stringBuilder.Clear();
                for (int j = 0; j < size - i - 1; j++)
                {
                    stringBuilder.Append(" ");
                }
                Console.Write(stringBuilder);
                stringBuilder.Clear();
                for (int k = 0; k < (2 * i) - 1; k++)
                {
                    stringBuilder.Append("*");
                }
                Console.WriteLine(stringBuilder);
            }
        }
    }
}
