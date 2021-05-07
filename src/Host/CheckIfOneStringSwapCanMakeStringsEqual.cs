using System.Collections.Generic;
using System.Linq;

public class CheckIfOneStringSwapCanMakeStringsEqual
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        var chars1 = s1.ToCharArray();
        var chars2 = s2.ToCharArray();
        var sum1 = chars1.Select(i => (int)i).Sum();
        var sum2 = chars2.Select(i => (int)i).Sum();
        if (sum1 != sum2)
        {
            return false;
        }
        char? firstListFirstLetter = null;
        char? secondListSecondLetter = null;
        var diff = 0;
        for (int i = 0; i < chars1.Length; i++)
        {
            if (diff > 2)
            {
                return false;
            }
            if (chars1[i] != chars2[i])
            {
                diff++;
                if (!firstListFirstLetter.HasValue)
                {
                    firstListFirstLetter = chars1[i];
                }
                else
                {
                    secondListSecondLetter = chars2[i];
                }
            }
        }
        if (diff == 2)
        {
            if (firstListFirstLetter != null && firstListFirstLetter == secondListSecondLetter)
            {
                return true;
            }
            return false;
        }
        if (diff == 0)
        {
            return true;
        }
        return false;
    }
}