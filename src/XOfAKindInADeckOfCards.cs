using System.Collections.Generic;
using System.Linq;

public class XOfAKindInADeckOfCards
{
    // not working for [1,1,1,1,2,2,2,2,2,2]
    public bool HasGroupsSizeX(int[] deck)
    {
        var partitions = new Dictionary<int, int>();
        for (int i = 0; i < deck.Length; i++)
        {
            if (partitions.ContainsKey(deck[i]))
            {
                partitions[deck[i]]++;
            }
            else
            {
                partitions.Add(deck[i], 1);
            }
        }
        var least = partitions.Values.Min();
        if (least < 2)
        {
            return false;
        }
        foreach (var value in partitions.Values)
        {
            if (value % least != 0)
            {
                return false;
            }
        }
        return true;
    }
}