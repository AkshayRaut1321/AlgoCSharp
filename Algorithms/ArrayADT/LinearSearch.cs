using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCSharp.Algorithms.ArrayADT
{
    public class LinearSearch
    {
        public int NativeSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                    return i;
            }
            return -1;
        }

        public int SearchWithTransposition(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    int previousPosition = i - 1;
                    if (i > 0)
                    {
                        int temp = array[i];
                        array[i] = array[previousPosition];
                        array[previousPosition] = temp;
                        i = previousPosition;
                    }
                    return i;
                }
            }
            return -1;
        }

        public int SearchMoveToFront(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    int temp = array[i];
                    array[i] = array[0];
                    array[0] = temp;
                    return i - 1;
                }
            }
            return -1;
        }

        public int BidirectionalSearch(int[] array, int key)
        {
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                if (array[i] == key)
                    return i;
                else if (array[j] == key)
                    return j;

                i++;
                j--;
            }
            return -1;
        }

        public int SearchWithDictionary(int[] array, int key)
        {
            Dictionary<int, int> positionMap = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                positionMap[array[i]] = i;
            }

            if (positionMap.ContainsKey(key))
                return positionMap[key];

            return -1;
        }
    }
}
