using System.Collections.Generic;

namespace AlgoCSharp.LeetCodeProblems
{
    internal class _1TwoSum
    {
        internal int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!values.ContainsKey(nums[i]))
                    values.Add(target - nums[i], i);
                else
                    return new int[2] { values[nums[i]], i };
            }
            return new int[2];
        }
    }
}
