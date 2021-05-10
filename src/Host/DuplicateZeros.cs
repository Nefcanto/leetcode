using System;

public class DuplicateZeros
{
    public void Slower(int[] arr)
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

    public void Faster(int[] arr)
    {
        var found = false;
        for (int i = 1; i < arr.Length; i++)
        {
            if (found)
            {
                found = false;
                continue;
            }
            if (arr[i - 1] == 0)
            {
                found = true;
                for (int j = arr.Length - 1; j >= i; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[i] = 0;
            }
        }
    }
}