using System;
using System.Collections.Generic;

public class Maximum69Number
{
    public int Find(int num)
    {
        var text = num.ToString();
        var firstSix = text.IndexOf("6");
        if (firstSix != -1)
        {
            text = text.Remove(firstSix, 1).Insert(firstSix, "9");
        }
        return Convert.ToInt32(text);
    }

    public int FindFaster(int num)
    {
        var nums = new List<int>();
        while (num > 0)
        {
            nums.Add(num % 10);
            num = num / 10;
        }
        nums.Reverse();
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == 6)
            {
                nums[i] = 9;
                break;
            }
        }
        nums.Reverse();
        var result = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            result += nums[i] * (int)Math.Pow(10, i);
        }
        return result;
    }
}