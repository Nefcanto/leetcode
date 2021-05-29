public class SumOfUniqueElements
{
    public int SumOfUnique(int[] nums)
    {
        var uniques = new HashSet<int>();
        var duplicates = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (uniques.Contains(nums[i]))
            {
                duplicates.Add(nums[i]);
            }
            else
            {
                uniques.Add(nums[i]);
            }
        }
        return uniques.Sum() - duplicates.Sum();
    }
}