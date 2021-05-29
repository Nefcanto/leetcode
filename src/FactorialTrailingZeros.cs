// not working
public class FactorialTrailingZeros
{
    public int TrailingZeroes(int n)
    {
        int fact = 1;
        var zeros = 0;
        for (int i = n; i >= 2; i--)
        {
            fact *= i;
            while (fact % 10 == 0)
            {
                zeros++;
                fact = fact / 10;
            }
            fact = fact % 10;
        }
        return zeros;
    }
}

// resulting in very big numbers
//public class Solution
//{
//    public int TrailingZeroes(int n)
//    {
//        double fac = 1;
//        for (int i = n; i >= 2; i--)
//        {
//            fac *= i;
//        }
//        var zeros = 0;
//        while (fac % 10 == 0)
//        {
//            zeros++;
//            fac = fac / 10;
//        }
//        return zeros;
//    }
//}