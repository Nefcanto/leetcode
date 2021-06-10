using System.Collections.Generic;

public class CheckArrayFormationThroughConcatenation
{
    public bool CanFormArray(int[] arr, int[][] pieces)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            dic.Add(arr[i], i);
        }
        for (int i = 0; i < pieces.Length; i++)
        {
            var first = pieces[i][0];
            if (!dic.ContainsKey(first))
            {
                return false;
            }
            var indexInArr = dic[first];
            for (int j = 0; j < pieces[i].Length; j++)
            {
                if (indexInArr + j >= arr.Length)
                {
                    return false;
                }
                if (arr[indexInArr + j] != pieces[i][j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}