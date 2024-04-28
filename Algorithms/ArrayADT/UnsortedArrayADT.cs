namespace AlgoCSharp.Algorithms.ArrayADT
{
    internal class UnsortedArrayADT
    {
        public int[] MergeSortedArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k] = a[i++];
                }
                else
                {
                    c[k] = b[j++];
                }
                k++;
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
        
        public int[] UnionSortedArrays(int[] a, int[] b)
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
                    c[k++] = b[j++];
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

        public int[] IntersectSortedArrays(int[] a, int[] b)
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

        public int[] DifferenceSortedArrays(int[] a, int[] b)
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
    }
}
