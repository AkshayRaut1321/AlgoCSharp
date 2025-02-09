using System.Collections.Generic;

namespace AlgoCSharp.Algorithms
{
    public class TwoSumProblem
    {
        //Single pair - Slightly faster.
        public int[] TwoSumStoreComplement(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!values.ContainsKey(nums[i]))
                {
                    int complement = target - nums[i];
                    values.Add(complement, i);
                }
                else
                    return new int[2] { values[nums[i]], i };
            }
            return new int[2];
        }

        //Single pair - Close to my previous approach.
        public int[] TwoSumStoreOriginalNumber(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (!values.ContainsKey(complement))
                    return new int[2] { values[complement], i };

                values.Add(nums[i], i);
            }
            return new int[2];
        }

        //Multiple pair - unnecessary nested iteration.
        public List<int[]> TwoSumStoreComplementReturnMultiple(int[] nums, int target)
        {
            Dictionary<int, List<int>> values = new Dictionary<int, List<int>>();
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (values.ContainsKey(nums[i]))
                {
                    foreach (int index in values[nums[i]]) // Get all indices of stored complement
                        result.Add(new int[] { index, i });
                }

                int complement = target - nums[i];
                if (!values.ContainsKey(complement))
                {
                    values.Add(complement, new List<int>());
                }
                values[complement].Add(i);
            }
            return result;
        }

        //Multiple pair - slightly faster due to no unnecessary nested iteration.
        public List<int[]> TwoSumStoreOriginalNumberReturnMultiple(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (values.ContainsKey(complement))
                {
                    result.Add(new int[] { values[complement], i });
                }

                // Store only if it's not already present to avoid duplicate pairs
                if (!values.ContainsKey(nums[i]))
                {
                    values[nums[i]] = i;
                }
            }

            return result;
        }
    }
}
