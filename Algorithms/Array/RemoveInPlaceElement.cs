namespace AlgoCSharp.Algorithms.Array
{
    internal class RemoveInPlaceElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0, j = 0;
            int arrayLength = nums.Length;

            for (; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    for (int k = i; k < nums.Length - 1; k++)
                    {
                        nums[k] = nums[k + 1];
                    }
                    i--;
                    j++;
                    arrayLength--;
                }
            }
            if (nums[j - 1] == val)
            {
                nums[j - 1] = 0;
                j--;
            }
            return j;
        }
    }
}
