using System;

namespace AlgoCSharp.Algorithms.ArrayADT
{
    internal class SortedArrayADT
    {
        public int[] MergeArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            
            for (; i < a.Length;)
            {
                c[k++] = a[i++];
            }
            for (; j < b.Length;)
            {
                c[k++] = b[j++];
            }

            return c;
        }
        
        public int[] UnionArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            for (; i < a.Length;)
            {
                c[k++] = a[i++];
            }
            for (; j < b.Length;)
            {
                //Check if b[j] exists in array c.
                int l = 0;
                while (l < c.Length && b[j] != c[l])
                {

                }
                c[k++] = b[j++];
            }
            while (j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else if (a[i] > b[j])
                {
                    c[k++] = b[j++];
                }
                else
                {
                    c[k++] = a[i++];
                    j++;
                }
            }

            return c;
        }

        public int[] IntersectArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    i++;
                }
                else if (a[i] > b[j])
                {
                    j++;
                }
                else
                {
                    c[k++] = a[i++];
                    j++;
                }
            }
            for (; i < a.Length;)
            {
                c[k++] = a[i++];
            }
            for (; j < b.Length;)
            {
                c[k] = b[j++];
            }

            return c;
        }

        public int[] DifferenceArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else if (a[i] > b[j])
                {
                    c[k++] = a[j++];
                }
            }
            for (; i < a.Length;)
            {
                c[k++] = a[i++];
            }
            for (; j < b.Length;)
            {
                c[k] = b[j++];
            }

            return c;
        }

        public void FindMissingNumbers(int[] numbers)
        {
            var diff = numbers[0] - 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] - i != diff)
                {
                    while (diff < numbers[i] - i)
                    {
                        Console.WriteLine(i + diff);
                        diff++;
                    }
                }
            }
        }
    }
}
