using System.Collections.Generic;

public class NextGreaterElementOne
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var nums1Dic = new Dictionary<int, int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            nums1Dic.Add(nums2[i], i);
        }
        for (int i = 0; i < nums1.Length; i++)
        {
            var indexInNums2 = nums1Dic[nums1[i]];
            var found = false;
            for (int j = indexInNums2; j < nums2.Length; j++)
            {
                if (nums2[j] > nums1[i])
                {
                    nums1[i] = nums2[j];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                nums1[i] = -1;
            }
        }
        return nums1;
    }
}