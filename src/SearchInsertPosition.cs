public class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        var foundFirstGreater = false;
        int place = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
            if (nums[i] > target && !foundFirstGreater)
            {
                foundFirstGreater = true;
                place = i;
            }
        }
        if (foundFirstGreater)
        {
            return place;
        }
        else
        {
            return nums.Length;
        }
    }
}