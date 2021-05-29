using System.Collections.Generic;
using System.Linq;

public class PascalTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var rows = new List<int[]>();
        for (int i = 1; i <= numRows; i++)
        {
            var row = new int[i];
            row[0] = 1;
            row[i - 1] = 1;
            for (int j = 1; j <= i - 2; j++)
            {
                row[j] = rows[i - 2][j - 1] + rows[i - 2][j];
            }
            rows.Add(row);
        }
        return (IList<IList<int>>)rows.ToArray();
    }
}