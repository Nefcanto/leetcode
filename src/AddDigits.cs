public class AddDigits
{
    public int Add(int num)
    {
        var sum = 0;
        do
        {
            sum += num % 10;
            num = num / 10;
            if (num < 10)
            {
                sum += num;
                num = sum;
                if (num >= 10)
                {
                    sum = 0;
                }
            }
        }
        while (num >= 10);
        return sum;
    }
}