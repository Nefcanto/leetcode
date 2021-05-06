public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var maxCount = 0;
        var currentCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 0;
            }
        }
        if (currentCount > maxCount)
        {
            return currentCount;
        }
        return maxCount;
    }
}