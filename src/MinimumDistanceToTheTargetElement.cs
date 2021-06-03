using System;

public class MinimumDistanceToTheTargetElement
{
    public int GetMinDistance(int[] nums, int target, int start)
    {
        var min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                min = Math.Min(Math.Abs(i - start), min);
            }
        }
        return min;
    }
}