using System.Collections.Generic;
using System.Text;

public class Solution
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
    
    // compare this with Java version at the end. Java 2ms, this 100ms.
    public bool CanFormArray2(int[] arr, int[][] pieces)
    {
        StringBuilder sb = new StringBuilder();
        foreach (int i in arr)
        {
            sb.Append("#");
            sb.Append(i);
            sb.Append("#");
        }
        for (int i = 0; i < pieces.Length; i++)
        {
            StringBuilder res = new StringBuilder();
            for (int j = 0; j < pieces[i].Length; j++)
            {
                res.Append("#");
                res.Append(pieces[i][j]);
                res.Append("#");
            }
            if (!sb.ToString().Contains(res.ToString()))
            {
                return false;
            }
        }
        return true;
    }
}

/*
class Solution {
    public boolean canFormArray(int[] arr, int[][] pieces) {
        StringBuilder sb = new StringBuilder();
        for(int x : arr){
			sb.append("#");
            sb.append(x);
            sb.append("#");
        }
        for(int i = 0; i < pieces.length; i++){
            StringBuilder res = new StringBuilder();
            for(int j = 0; j < pieces[i].length; j++){
				res.append("#");
                res.append(pieces[i][j]);
                res.append("#");
            }
            if(!sb.toString().contains(res.toString())){
                return false;
            }
        }
        return true;
    }
}
*/