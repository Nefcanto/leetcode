public class PlusOne
{
    public int[] Perform(int[] digits)
    {
        bool extend = false;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            var sum = digits[i] + 1;
            if (sum <= 9)
            {
                digits[i] = sum;
                break;
            }
            else
            {
                digits[i] = sum % 10;
                if (i == 0)
                {
                    extend = true;
                }
            }
        }
        if (extend)
        {
            var result = new int[digits.Length + 1];
            result[0] = 1;
            for (int j = 0; j < digits.Length; j++)
            {
                result[j + 1] = digits[j];
            }
            digits = result;
        }
        return digits;
    }
}