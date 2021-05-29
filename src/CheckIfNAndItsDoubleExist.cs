using System.Collections.Generic;

public class CheckIfNAndItsDoubleExist
{
    public bool CheckIfExist(int[] arr)
    {
        var search = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!search.ContainsKey(arr[i]))
            {
                search.Add(arr[i], i);
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            var @double = arr[i] * 2;
            if (search.ContainsKey(@double) && search[@double] != i)
            {
                return true;
            }
        }
        return false;
    }
}