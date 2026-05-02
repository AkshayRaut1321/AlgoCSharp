using System;

namespace AlgoCSharp.LeetCodeProblems
{
    internal class KadaneAlgorithm
    {
        internal int MaxSubarraySum(int[] nums)
        {
            int currentSum = nums[0];
            int maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                // Decide: extend or restart
                currentSum = Math.Max(nums[i], currentSum + nums[i]);

                // Track global maximum
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
