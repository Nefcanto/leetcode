public class MaxPower
{
    public int Find(string s)
    {
        var power = 0;
        var charCount = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                charCount++;
            }
            else
            {
                charCount = 0;
            }
            if (charCount > power)
            {
                power = charCount;
            }
        }
        return power + 1;
    }
}