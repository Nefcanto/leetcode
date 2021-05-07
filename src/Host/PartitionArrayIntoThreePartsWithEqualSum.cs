using System.Linq;

public class PartitionArrayIntoThreePartsWithEqualSum
{
    public bool CanThreePartsEqualSum(int[] arr)
    {
        var first = 0;
        var second = 0;
        var border = 1;
        for (int i = 0; i < border - 1; i++)
        {
            first += arr[i];
        }
        var all = arr.ToList().Sum();
        while (border < arr.Length)
        {
            second = 0;
            first += arr[border - 1];
            for (int i = border; i < arr.Length; i++)
            {
                second += arr[i];
                if (first == second)
                {
                    if (i == arr.Length - 1)
                    {
                        return false;
                    }
                    if (all - first - second == first)
                    {
                        return true;
                    }
                }
            }
            border++;
        }
        return false;
    }
}