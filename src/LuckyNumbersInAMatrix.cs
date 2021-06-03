using System.Collections.Generic;

public class LuckyNumbersInAMatrix
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var minInRows = new Dictionary<int, int>();
        var luckyNumbers = new List<int>();
        for (int i = 0; i < matrix.Length; i++)
        {
            var min = matrix[i][0];
            var minIndex = 0;
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] < min)
                {
                    min = matrix[i][j];
                    minIndex = j;
                }
            }
            bool isMax = true;
            for (int j = 0; j < matrix.Length; j++)
            {
                if (matrix[j][minIndex] > min)
                {
                    isMax = false;
                    break;
                }
            }
            if (isMax)
            {
                luckyNumbers.Add(min);
            }
        }
        return luckyNumbers;
    }
}