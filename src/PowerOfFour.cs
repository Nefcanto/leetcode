using System;

public class PowerOfFour
{
    public bool IsPowerOfFour(int n)
    {
        if (n < 0)
        {
            return false;
        }
        n = Math.Abs(n);
        var x = 0;
        long result = 1;
        while (result < n)
        {
            result *= 4;
            x++;
        }
        return result == n;
    }
}