using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoCSharp.Algorithms.ArrayADT
{
    public class ArrayAlgorithms
    {
        public int FindSingleElementMissingBy1PlaceInSortedNaturalNumbersUsingFormula(params int[] numbers)
        {
            int actualSum = numbers.Sum();
            int totalElements = numbers.Length + 1;
            int expectedSum = totalElements * (totalElements + 1) / 2;
            return expectedSum - actualSum;
        }

        public void FindSingleElementMissingBy1PlaceInSortedPositiveIntegers(params int[] numbers)
        {
            var diff = numbers[0] - 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - i != diff)
                {
                    Console.WriteLine(i + diff);
                    break;
                }
            }
        }

        public void FindMultipleMissingNumbersInSortedPositiveIntegers(params int[] numbers)
        {
            var currentDiff = numbers[0] - 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var newDiff = numbers[i] - i;
                if (newDiff != currentDiff)
                {
                    while (currentDiff < newDiff)
                    {
                        Console.WriteLine(i + currentDiff);
                        currentDiff++;
                    }
                }
            }
        }

        public void FindMultipleMissingNumbersUnsortedPositiveIntegers(int[] numbers)
        {
            int max = int.MinValue;
            //write code to find min and max from numbers array.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                    max = numbers[i];
            }

            int[] result = new int[max + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[numbers[i]] = 1;
            }
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == 0)
                    Console.WriteLine(i);
            }
        }

        public void FindUniqueDuplicatesSortedPositiveIntegersNonHash(params int[] numbers)
        {
            int lastDuplicate = int.MinValue;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] != lastDuplicate)
                {
                    Console.WriteLine(numbers[i]);
                    lastDuplicate = numbers[i];
                }
            }
        }

        /// <summary>
        /// Conditions and assumptions are:
        /// Ask whether they want to include original number in the duplicate count or not.
        /// Numbers should have positive integers.
        /// Numbers should be sorted.
        /// 0 may or may not be present in the array.
        /// </summary>
        /// <param name="numbers"></param>
        public void CountDuplicatesSortedPositiveIntegersHash(params int[] numbers)
        {
            int lastDuplicate = int.MinValue;
            Dictionary<int, int> countDuplicates = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    if (numbers[i] == lastDuplicate)
                        countDuplicates[numbers[i]]++;
                    else
                    {
                        lastDuplicate = numbers[i];
                        countDuplicates[numbers[i]] = 1;
                    }
                }
            }

            foreach (var item in countDuplicates)
            {
                Console.WriteLine($"{item.Key} is duplicate {item.Value} times");
            }
        }

        /// <summary>
        /// Conditions and assumptions are:
        /// Ask whether they want to include original number in the duplicate count or not.
        /// Numbers should have positive integers.
        /// Numbers may or may not be sorted.
        /// 0 may or may not be present in the array.
        /// </summary>
        /// <param name="numbers"></param>
        public void CountDuplicatesUnsortedPositiveIntegersHash(params int[] numbers)
        {
            Dictionary<int, int> countDuplicates = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (!countDuplicates.ContainsKey(numbers[i]))
                    countDuplicates[numbers[i]] = 0;
                else
                    countDuplicates[numbers[i]]++;
            }

            foreach (var item in countDuplicates)
            {
                if (item.Value > 0)
                    Console.WriteLine($"{item.Key} is duplicate {item.Value} times");
            }
        }
    }
}
