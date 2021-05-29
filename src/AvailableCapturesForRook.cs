using System.Collections.Generic;
using System.Text;

public class AvailableCapturesForRook
{
    public int NumRookCaptures(char[][] board)
    {
        int captures = 0;
        for (int row = 0; row < 8; row++)
        {
            var sb = new StringBuilder();
            for (int col = 0; col < 8; col++)
            {
                if (board[row][col] != '.')
                {
                    sb.Append(board[row][col]);
                }
            }
            var text = sb.ToString();
            if (text.Contains("pR"))
            {
                captures++;
            }
            if (text.Contains("Rp"))
            {
                captures++;
            }
        }
        for (int col = 0; col < 8; col++)
        {
            var sb = new StringBuilder();
            for (int row = 0; row < 8; row++)
            {
                if (board[row][col] != '.')
                {
                    sb.Append(board[row][col]);
                }
            }
            var text = sb.ToString();
            if (text.Contains("pR"))
            {
                captures++;
            }
            if (text.Contains("Rp"))
            {
                captures++;
            }
        }
        return captures;
    }
}