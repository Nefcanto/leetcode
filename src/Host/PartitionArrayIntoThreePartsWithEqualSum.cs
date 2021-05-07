// slow
public class PartitionArrayIntoThreePartsWithEqualSum
{
    public bool CanThreePartsEqualSum(int[] arr)
    {
        var first = 0;
        var second = 0;
        var third = 0;
        var border = 1;
        while (border < arr.Length)
        {
            first = 0;
            second = 0;
            third = 0;
            for (int i = 0; i < border; i++)
            {
                first += arr[i];
            }
            for (int i = border; i < arr.Length; i++)
            {
                second += arr[i];
                if (first == second)
                {
                    if (i == arr.Length - 1)
                    {
                        return false;
                    }
                    third = 0;
                    for (int z = arr.Length - 1; z > i; z--)
                    {
                        third += arr[z];
                    }
                    if (second == third)
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