public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var lastIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var index = t.IndexOf(s[i].ToString(), lastIndex);
            if (index == -1)
            {
                return false;
            }
            lastIndex = index + 1;
        }
        return true;
    }
}