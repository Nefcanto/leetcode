using System;
using System.Collections.Generic;
using System.Linq;

public class SortIntegersByTheNumberOfOneBits
{
    public int[] SortByBits(int[] arr)
    {
        var dic = new Dictionary<int, List<int>>();
        for (int i = 0; i < arr.Length; i++)
        {
            var binary = Convert.ToString(arr[i], 2);
            binary = binary.Replace("0", "");
            if (dic.ContainsKey(binary.Length))
            {
                dic[binary.Length].Add(arr[i]);
            }
            else
            {
                dic.Add(binary.Length, new List<int> { arr[i] });
            }
        }
        var sortedKeys = dic.Keys.ToArray();
        Array.Sort(sortedKeys);
        var result = new List<int>();
        for (int i = 0; i < sortedKeys.Length; i++)
        {
            var items = dic[sortedKeys[i]].ToArray();
            Array.Sort(items);
            result.AddRange(items);
        }
        return result.ToArray();
    }
}