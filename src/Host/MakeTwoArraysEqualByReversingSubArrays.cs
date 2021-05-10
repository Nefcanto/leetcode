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

    public bool Faster(int[] target, int[] arr)
    {
        var countMap = new int[1001];
        for (int i = 0; i < target.Length; i++)
        {
            countMap[target[i]]++;
            countMap[arr[i]]--;
        }
        for (int i = 0; i < countMap.Length; i++)
        {
            if (countMap[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}