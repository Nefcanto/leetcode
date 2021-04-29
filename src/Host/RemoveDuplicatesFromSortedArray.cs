public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return 1;
        }
        var cursor = 0;
        var maxValueIndex = nums.Length - 1;
        while (cursor < maxValueIndex)
        {
            if (nums[cursor] == nums[cursor + 1])
            {
                for (int i = 1; i < maxValueIndex; i++)
                {
                    if (cursor + i + 1 > nums.Length - 1)
                    {
                        continue;
                    }
                    nums[cursor + i] = nums[cursor + i + 1];
                }
                maxValueIndex--;
            }
            else
            {
                cursor++;
            }
        }
        return maxValueIndex + 1;
    }
}