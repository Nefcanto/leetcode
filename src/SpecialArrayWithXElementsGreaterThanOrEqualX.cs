using System.Linq;

// not working
public class SpecialArrayWithXElementsGreaterThanOrEqualX
{
    public int SpecialArray(int[] nums)
    {
        var sorted = nums.OrderBy(i => i).ToList();
        var x = 1;
        var index = nums.Length - 1;
        var greaters = 0;
        while (index >= 0)
        {
            if (sorted[index] >= x)
            {
                greaters++;
            }
            x++;
            index--;
        }
        if (x == greaters)
        {
            return x;
        }
        return -1;
    }
}