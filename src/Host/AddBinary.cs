using System.Text;

public class AddBinary
{
    public string Add(string a, string b)
    {
        if (a.Length > b.Length)
        {
            b = b.PadLeft(a.Length, '0');
        }
        else
        {
            a = a.PadLeft(b.Length, '0');
        }
        var result = new int[a.Length];
        var carry = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == '1' && b[i] == '1')
            {
                if (carry == 1)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
                carry = 1;
            }
            else if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1'))
            {
                if (carry == 1)
                {
                    result[i] = 0;
                    carry = 1;
                }
                else
                {
                    result[i] = 1;
                    carry = 0;
                }
            }
            else
            {
                result[i] = carry;
                carry = 0;
            }
        }
        var added = string.Join(' ', result).Replace(" ", "");
        if (carry == 1)
        {
            added = "1" + added;
        }
        return added;
    }
}