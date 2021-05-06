using System.Collections.Generic;
using System.Linq;

public class PascalTriangleTwo
{
    public IList<int> GetRow(int rowIndex)
    {
        var rows = new List<int[]>();
        for (int i = 0; i <= rowIndex; i++)
        {
            rows.Add(new int[i + 1]);
            rows[i][0] = 1;
            rows[i][i] = 1;
            for (int j = 1; j < i; j++)
            {
                rows[i][j] = rows[i - 1][j - 1] + rows[i - 1][j];
            }
        }
        return rows[rowIndex].ToList();
    }
}