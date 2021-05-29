public class Solution
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        var count = 0;
        for (int i = 0; i < startTime.Length; i++)
        {
            if (startTime[i] <= queryTime && endTime[i] >= queryTime)
            {
                count++;
            }
        }
        return count;
    }
}