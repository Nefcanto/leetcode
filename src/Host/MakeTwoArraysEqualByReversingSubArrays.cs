using System;

public class MakeTwoArraysEqualByReversingSubArrays
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        Array.Sort(target);
        Array.Sort(arr);
        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] != arr[i])
            {
                return false;
            }
        }
        return true;
    }
}