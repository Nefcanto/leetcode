using System.Collections.Generic;
using System.Linq;

public class RelativeSortArray
{
    public int[] Sort(int[] arr1, int[] arr2)
    {
        var values = new Dictionary<int, List<int>>();
        var lasts = new List<int>();
        for (int i = 0; i < arr2.Length; i++)
        {
            values.Add(arr2[i], new List<int>());
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            if (values.ContainsKey(arr1[i]))
            {
                values[arr1[i]].Add(arr1[i]);
            }
            else
            {
                lasts.Add(arr1[i]);
            }
        }
        return values.SelectMany(i => i.Value).Concat(lasts.OrderBy(x => x)).ToArray();
    }
}