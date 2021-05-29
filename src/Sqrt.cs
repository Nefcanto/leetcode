public class Sqrt
{
    public int MySqrt(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        decimal root = x / 2;
        decimal half = root / 2;
        while (half > 0.1M)
        {
            if (root * root > x)
            {
                root -= half;
            }
            else
            {
                root += half;
            }
            half = half / 2;
        }
        return (int)root;
    }
}