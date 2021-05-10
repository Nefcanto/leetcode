using System;

public class MaximumUnitsOnATruck
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, new Comparison<int[]>((a, b) =>
        {
            if (a[1] < b[1])
            {
                return 1;
            }
            else if (a[1] > b[1])
            {
                return -1;
            }
            return 0;
        }));
        var units = 0;
        var boxes = 0;
        for (int i = 0; i < boxTypes.Length; i++)
        {
            if (truckSize - boxes >= boxTypes[i][0])
            {
                units += boxTypes[i][0] * boxTypes[i][1];
                boxes += boxTypes[i][0];
            }
            else
            {
                units += (truckSize - boxes) * boxTypes[i][1];
                break;
            }
        }
        return units;
    }
}