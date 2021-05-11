using System;
using System.Collections.Generic;

// not working for [[1,1],[2,2],[7,7]]
public class Solution
{
    public bool IsBoomerang(int[][] points)
    {
        var distinct = new HashSet<int>();
        for (int i = 0; i < points.Length; i++)
        {
            var n = points[i][0] * 10 + points[i][1];
            if (distinct.Contains(n))
            {
                return false;
            }
            distinct.Add(n);
        }
        var firstPoint = points[0];
        var secondPoint = points[1];
        var thirdPoint = points[2];
        var sideA = Math.Sqrt(Math.Pow(secondPoint[1] - firstPoint[1], 2) + Math.Pow(secondPoint[0] - firstPoint[0], 2));
        var sideB = Math.Sqrt(Math.Pow(secondPoint[1] - thirdPoint[1], 2) + Math.Pow(secondPoint[0] - thirdPoint[0], 2));
        var sideC = Math.Sqrt(Math.Pow(firstPoint[1] - thirdPoint[1], 2) + Math.Pow(firstPoint[0] - thirdPoint[0], 2));

        if (sideA + sideB > sideC)
        {
            return true;
        }
        return false;
    }
}