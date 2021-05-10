using System;

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        var text = "";
        for (int i = 0; i < arr.Length; i++)
        {
            text += arr[i].ToString();
        }
        text = text.Replace("0", "00");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(text[i].ToString());
        }
    }
}