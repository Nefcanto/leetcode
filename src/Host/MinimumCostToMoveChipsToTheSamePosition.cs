using System;
using System.Collections.Generic;

// not passing all the tests
public class MinimumCostToMoveChipsToTheSamePosition
{
    public int MinCostToMoveChips(int[] position)
    {
        var dic = new Dictionary<int, int>();
        var max = 0;
        var maxIndex = 0;
        for (int i = 0; i < position.Length; i++)
        {
            if (dic.ContainsKey(position[i]))
            {
                dic[position[i]]++;
            }
            else
            {
                dic.Add(position[i], 1);
            }
            if (dic[position[i]] > max)
            {
                max = dic[position[i]];
                maxIndex = position[i];
            }
        }
        var cost = 0;
        for (int i = 0; i < position.Length; i++)
        {
            if (Math.Abs(position[i] - maxIndex) % 2 != 0)
            {
                cost++;
            }
        }
        return cost;
    }
}