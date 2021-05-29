using System;
using System.Collections.Generic;

public class ContainsDuplicateTwo
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var uniques = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (uniques.ContainsKey(nums[i]))
            {
                if (Math.Abs(i - uniques[nums[i]]) <= k)
                {
                    return true;
                }
                else
                {
                    uniques[nums[i]] = i;
                }
            }
            else
            {
                uniques.Add(nums[i], i);
            }
        }
        return false;
    }
}