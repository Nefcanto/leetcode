public class CalculateMoneyInLeetCodeBank
{
    public int TotalMoney(int n)
    {
        var day = 1;
        var dayAmount = 0;
        var week = 0;
        var total = 0;
        while (day <= n)
        {
            if (day % 7 == 1)
            {
                week++;
                dayAmount = week;
            }
            else
            {
                dayAmount++;
            }
            total += dayAmount;
            day++;
        }
        return total;
    }
}