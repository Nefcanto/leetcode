using System.Collections.Generic;
using System.Linq;

public class NumberOfGoodPairs
{
    public int NumIdenticalPairs(int[] nums)
    {
        var positions = new Dictionary<int, List<int>>();
        var pairsCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (positions.ContainsKey(nums[i]))
            {
                pairsCount += positions[nums[i]].Count();
                positions[nums[i]].Add(i);
            }
            else
            {
                positions.Add(nums[i], new List<int> { i });
            }
        }
        return pairsCount;
    }
}