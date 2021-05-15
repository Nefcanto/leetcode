using System;

public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle)
    {
        // it's basically a number system of base 26 (uppercase English alphabet representing numbers), just like decimal, binary, and hexadecimal systems
        var dec = 0;
        for (int i = columnTitle.Length - 1; i >= 0; i--)
        {
            var @char = columnTitle[i];
            var digit = ((int)@char) - 64;
            var power = (int)Math.Pow(26, columnTitle.Length - i - 1);
            if (power == 1)
            {
                power = 0;
                digit += digit * power;
            }
            else
            {
                digit = digit * power;
            }
            dec += digit;
        }
        return dec;
    }
}