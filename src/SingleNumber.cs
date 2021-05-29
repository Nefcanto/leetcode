using System.Collections.Generic;

public class SingleNumber
{
    public int Find(int[] nums)
    {
        var count = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (count.ContainsKey(nums[i]))
            {
                count[nums[i]]++;
            }
            else
            {
                count.Add(nums[i], 1);
            }
        }
        foreach (var item in count.Keys)
        {
            if (count[item] == 1)
            {
                return item;
            }
        }
        return nums[0];
    }
}