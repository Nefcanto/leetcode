using System;

public class MaximumAscendingSubarraySum
{
    public int MaxAscendingSum(int[] nums)
    {
        var max = nums[0];
        var tempMax = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                if (tempMax == 0)
                {
                    tempMax = nums[i - 1];
                }
                tempMax += nums[i];
            }
            else
            {
                tempMax = 0;
                max = Math.Max(max, nums[i]);
            }
            max = Math.Max(tempMax, max);
        }
        return max;
    }
}