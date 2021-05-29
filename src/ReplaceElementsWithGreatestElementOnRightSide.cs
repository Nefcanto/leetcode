public class ReplaceElementsWithGreatestElementOnRightSide
{
    public int[] ReplaceElements(int[] arr)
    {
        var max = arr[arr.Length - 1];
        var old = arr[arr.Length - 1];
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            max = Math.Max(arr[i + 1], old);
            old = arr[i];
            arr[i] = max;
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
}