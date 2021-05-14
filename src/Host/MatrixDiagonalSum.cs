public class MatrixDiagonalSum
{
    public int DiagonalSum(int[][] mat)
    {
        var sum = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            if (i == mat.Length - i - 1)
            {
                sum += mat[i][i];
            }
            else
            {
                sum += mat[i][i];
                sum += mat[i][mat.Length - 1 - i];
            }
        }
        return sum;
    }
}