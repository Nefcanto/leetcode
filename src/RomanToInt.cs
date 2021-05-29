using System.Collections.Generic;
using System.Linq;

public class RomanToInt
{
    public int Convert(string roman)
    {
        var result = new List<int>();
        var matches = new Dictionary<string, int>();
        matches.Add("I", 1);
        matches.Add("V", 5);
        matches.Add("X", 10);
        matches.Add("L", 50);
        matches.Add("C", 100);
        matches.Add("D", 500);
        matches.Add("M", 1000);
        matches.Add("IV", 4);
        matches.Add("IX", 9);
        matches.Add("XL", 40);
        matches.Add("XC", 90);
        matches.Add("CD", 400);
        matches.Add("CM", 900);

        while (roman.Length > 0)
        {
            if (matches.ContainsKey(roman))
            {
                result.Add(matches[roman]);
                roman = "";
                continue;
            }
            var next = roman.Substring(0, 1);
            var nextTwo = roman.Substring(0, 2);
            if (matches.ContainsKey(nextTwo))
            {
                result.Add(matches[nextTwo]);
                roman = roman.Substring(2);
            }
            else
            {
                result.Add(matches[next]);
                roman = roman.Substring(1);
            }
        }
        var number = result.Sum();
        return number;
    }
}