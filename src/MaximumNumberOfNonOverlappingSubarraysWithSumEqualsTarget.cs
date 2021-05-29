// working partially
public class MaximumNumberOfNonOverlappingSubarraysWithSumEqualsTarget
{
    public int MaxNonOverlapping(int[] nums, int target)
    {
        var index = 0;
        var sum = 0;
        var count = 0;
        while (index < nums.Length)
        {
            sum = 0;
            bool found = false;
            for (int i = index; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == target)
                {
                    count++;
                    index = i + 1;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                index = index + 1;
            }
        }
        return count;
    }
}