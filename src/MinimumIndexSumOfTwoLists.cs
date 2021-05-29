using System.Collections.Generic;
using System.Linq;

public class MinimumIndexSumOfTwoLists
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var matches = new Dictionary<string, int[]>();
        for (int i = 0; i < list1.Length; i++)
        {
            matches.Add(list1[i], new int[] { 1, i });
        }
        for (int i = 0; i < list2.Length; i++)
        {
            if (matches.ContainsKey(list2[i]))
            {
                matches[list2[i]][0] += 1;
                matches[list2[i]][1] += i;
            }
            else
            {
                matches.Add(list2[i], new int[] { 1, i });
            }
        }
        var sorted = new SortedList<int, List<string>>();
        foreach (var key in matches.Keys)
        {
            if (matches[key][0] > 1)
            {
                if (sorted.ContainsKey(matches[key][1]))
                {
                    sorted[matches[key][1]].Add(key);
                }
                else
                {
                    sorted.Add(matches[key][1], new List<string> { key });
                }
            }
        }
        return sorted.First().Value.ToArray();
    }
}