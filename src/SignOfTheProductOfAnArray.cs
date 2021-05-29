public class SignOfTheProductOfAnArray
{
    public int ArraySign(int[] nums)
    {
        var negatives = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                return 0;
            }
            if (nums[i] < 0)
            {
                negatives++;
            }
        }
        return negatives % 2 == 0 ? 1 : -1;
    }
}