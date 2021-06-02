public class CountNegativeNumbersInASortedMatrix
{
    public int CountNegatives(int[][] grid)
    {
        var total = grid.Length * grid[0].Length;
        var row = 0;
        var column = 0;
        var positives = 0;
        while (row < grid.Length)
        {
            column = 0;
            while (column < grid[row].Length)
            {
                if (grid[row][column] < 0)
                {
                    column++;
                    break;
                }
                positives++;
                column++;
            }
            row++;
        }
        return total - positives;
    }
}