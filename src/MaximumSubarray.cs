using System;
using System.Collections.Generic;
using System.Linq;

public class MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        // I couldn't solve this one
        throw new NotImplementedException();
    }

    // this code was slow and exceeded time constraints
    //public int MaxSubArray(int[] nums)
    //{
    //    var all = new Dictionary<int[], int>();
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        for (int j = i + 1; j <= nums.Length; j++)
    //        {
    //            var subarray = new int[j];
    //            var sum = 0;
    //            var index = 0;
    //            for (int z = i; z < j; z++)
    //            {
    //                subarray[index] = nums[z];
    //                sum += nums[z];
    //                index++;
    //            }
    //            all.Add(subarray, sum);
    //        }
    //    }
    //    all.Add(nums, nums.Sum());
    //    var max = all.OrderByDescending(i => i.Value).FirstOrDefault();
    //    return max.Value;
    //}
}