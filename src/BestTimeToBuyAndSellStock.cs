public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var max = 0;
        var lowest = 0;
        var highest = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < prices[lowest])
            {
                lowest = i;
            }
            if (prices[i] > prices[highest])
            {
                highest = i;
            }
            if (lowest > highest)
            {
                highest = lowest;
            }
            if (prices[highest] - prices[lowest] > max)
            {
                max = prices[highest] - prices[lowest];
            }
        }
        return max;
    }
}

/*
very slow

public class BestTimeToBuyAndSellStock {
    public int MaxProfit(int[] prices) {
        var max = 0;
        for (int i = 0; i < prices.Length; i++) {
            for (int j = i; j < prices.Length; j++) {
                if (prices[j] - prices[i] > max) {
                    max = prices[j] - prices[i];
                }
            }
        }
        return max;
    }
}
*/