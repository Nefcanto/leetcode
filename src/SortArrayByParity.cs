using System.Collections.Generic;
using System.Linq;

public class SortArrayByParity
{
    public int[] NotInPlaceButFast(int[] nums)
    {
        var evens = new List<int>();
        var odds = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evens.Add(nums[i]);
            }
            else
            {
                odds.Add(nums[i]);
            }
        }
        return evens.Concat(odds).ToArray();
    }

    public int[] InPlaceButSlower(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] % 2 == 0)
            {
                left++;
                continue;
            }
            while (right > left)
            {
                if (nums[right] % 2 == 0)
                {
                    var swap = nums[right];
                    nums[right] = nums[left];
                    nums[left] = swap;
                    left++;
                    right--;
                    break;
                }
                else
                {
                    right--;
                    continue;
                }
            }
        }
        return nums;
    }
}