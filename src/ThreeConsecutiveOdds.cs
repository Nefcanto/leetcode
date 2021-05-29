public class ThreeConsecutiveOdds
{
    public bool Check(int[] arr)
    {
        if (arr.Length < 3)
        {
            return false;
        }
        for (int i = 2; i < arr.Length; i++)
        {
            var threeOdds = arr[i] % 2 == 1 && arr[i - 1] % 2 == 1 && arr[i - 2] % 2 == 1;
            if (threeOdds)
            {
                return true;
            }
        }
        return false;
    }
}