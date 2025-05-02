namespace AlgoCSharp.LeetCodeProblems
{
    public class RemoveAllMatchingElements
    {
        public int RemoveElement(int[] nums, int val)
        {
            int writeIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[writeIndex] = nums[i];
                    writeIndex++;
                }
            }
            return writeIndex;
        }
    }
}
