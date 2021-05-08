using System;

public class NumberOfRectanglesThatCanFormTheLargestSquare
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        var maxLen = 0;
        var count = 0;
        var mins = new int[rectangles.Length];
        for (int i = 0; i < rectangles.Length; i++)
        {
            var min = Math.Min(rectangles[i][0], rectangles[i][1]);
            if (min > maxLen)
            {
                maxLen = min;
            }
            mins[i] = min;
        }
        for (int i = 0; i < mins.Length; i++)
        {
            if (mins[i] >= maxLen)
            {
                count++;
            }
        }
        return count;
    }
}