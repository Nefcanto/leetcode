public class ValidPalindromeII
{
    // not working for "abc"
    public bool ValidPalindrome(string s)
    {
        var removals = 0;
        var j = s.Length - 1;
        for (int i = 0; i <= j; i++)
        {
            if (removals > 1)
            {
                return false;
            }
            if (s[i] == s[j])
            {
                j--;
                continue;
            }
            if (s[i] == s[j - 1])
            {
                j--;
                j--;
                removals++;
                continue;
            }
            if (s[i + 1] == s[j])
            {
                removals++;
                continue;
            }
        }
        return true;
    }
}