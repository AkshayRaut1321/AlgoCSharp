using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCSharp.Algorithms.ArrayADT
{
    public class BinarySearch
    {
        public int Iterative(int[] a, int key)
        {
            int low = 0;
            int high = a.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (a[mid] == key)
                    return mid;
                else if (key < a[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }

        public int RecursiveBinarySearch(int[] a, int low, int high, int key)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;

                if (key == a[mid])
                    return mid;
                else if (key < a[mid])
                    return RecursiveBinarySearch(a, low, mid - 1, key);
                else
                    return RecursiveBinarySearch(a, mid + 1, high, key);
            }
            return -1;
        }
    }
}
