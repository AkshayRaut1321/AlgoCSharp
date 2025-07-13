using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCSharp.LeetCodeProblems
{
    public class SearchInsertPositionInSortedArray
    {
        public int SearchInsertBruteForce(int[] nums, int target)
        {
            int i = 0;
            for (; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] > target)
                    return i;
            }
            return i;
        }

        public int SearchInsertBinaryOptimal(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            // If not found, left is the correct insert position
            return left;
        }
    }
}
