public class TeemoAttacking
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        var sum = 0;
        for (int i = 0; i < timeSeries.Length - 1; i++)
        {
            var min = Math.Min(timeSeries[i] + duration - 1, timeSeries[i + 1] - 1);
            sum += (min - timeSeries[i]) + 1;
        }
        return sum + duration;
    }
}