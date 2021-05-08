using System;

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
}