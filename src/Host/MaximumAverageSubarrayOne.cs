// not efficient => times out for large arrays

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var averages = new SortedList<double, int>();
        for (int i = 0; i <= nums.Length - k; i++)
        {
            double average = 0;
            for (int j = i; j < i + k; j++)
            {
                average += nums[j];
            }
            average = average / k;
            if (averages.ContainsKey(average))
            {
                continue;
            }
            averages.Add(average, 0);
        }
        return averages.Keys.Last();
    }
}