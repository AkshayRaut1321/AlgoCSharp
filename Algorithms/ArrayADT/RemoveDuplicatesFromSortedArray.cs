using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.ArrayADT
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicatesIterative(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int j = 0;  // Pointer to track the unique elements' positions

            // Iterate through the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // If the current element is different from the previous one
                if (nums[i] != nums[j])
                {
                    j++;  // Move the unique pointer forward
                    nums[j] = nums[i];  // Update the unique position with the new unique element
                }
            }

            // j + 1 is the count of unique elements
            return j + 1;
        }

        public int RemoveDuplicatesUniqueSet(int[] nums)
        {
            HashSet<int> uniqueElements = new HashSet<int>();

            foreach (var num in nums)
            {
                uniqueElements.Add(num);
            }

            int index = 0;
            foreach (var num in uniqueElements)
            {
                nums[index++] = num;
            }

            return uniqueElements.Count;
        }

        public int RemoveDuplicatesAllComparison(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        // Shift all elements after j one position to the left
                        for (int k = j; k < n - 1; k++)
                        {
                            nums[k] = nums[k + 1];
                        }
                        n--; // Decrease the size of the array
                        j--; // Decrease j to recheck the new value at index j
                    }
                }
            }

            return n;
        }

    }
}