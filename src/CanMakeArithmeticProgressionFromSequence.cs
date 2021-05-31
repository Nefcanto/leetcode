using System;

public class CanMakeArithmeticProgressionFromSequence
{
    public bool Check(int[] arr)
    {
        Array.Sort(arr);
        var step = arr[1] - arr[0];
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != step)
            {
                return false;
            }
        }
        return true;
    }
}