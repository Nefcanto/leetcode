using System;

public class ImageSmoother
{
    public int[][] MakeSmooth(int[][] img)
    {
        var result = new int[img.Length][];
        var count = 0;
        for (int row = 0; row < img.Length; row++)
        {
            result[row] = new int[img[row].Length];
            for (int col = 0; col < img[row].Length; col++)
            {
                count = 0;
                result[row][col] = img[row][col];
                count++;
                if (col < img[row].Length - 1)
                {
                    result[row][col] += img[row][col + 1];
                    count++;
                    if (row > 0)
                    {
                        result[row][col] += img[row - 1][col + 1];
                        count++;
                    }
                    if (row < img.Length - 1)
                    {
                        result[row][col] += img[row + 1][col + 1];
                        count++;
                    }
                }
                if (col > 0)
                {
                    result[row][col] += img[row][col - 1];
                    count++;
                    if (row > 0)
                    {
                        result[row][col] += img[row - 1][col - 1];
                        count++;
                    }
                    if (row < img.Length - 1)
                    {
                        result[row][col] += img[row + 1][col - 1];
                        count++;
                    }
                }
                if (row > 0)
                {
                    result[row][col] += img[row - 1][col];
                    count++;
                }
                if (row < img.Length - 1)
                {
                    result[row][col] += img[row + 1][col];
                    count++;
                }
                result[row][col] = (int)Math.Floor((decimal)result[row][col] / count);
            }
        }
        return result;
    }
}