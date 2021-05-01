public class LengthOfLastWord
{
    public int Find(string s)
    {
        s = s.Trim();
        var l = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                l++;
            }
            else
            {
                break;
            }
        }
        return l;
    }
}