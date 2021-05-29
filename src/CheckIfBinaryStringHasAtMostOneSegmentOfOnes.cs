public class CheckIfBinaryStringHasAtMostOneSegmentOfOnes
{
    public bool CheckOnesSegment(string s)
    {
        var ones = 0;
        var started = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                if (!started)
                {
                    ones++;
                }
                started = true;
            }
            if (s[i] == '0')
            {
                started = false;
            }
            if (ones > 1)
            {
                return false;
            }
        }
        return ones == 1;
    }
}