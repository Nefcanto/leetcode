using System.Collections;

public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        var target = new ArrayList(nums.Length);
        for (int i = 0; i < index.Length; i++)
        {
            target.Insert(index[i], nums[i]);
        }
        return (int[])target.ToArray(typeof(int));
    }
}