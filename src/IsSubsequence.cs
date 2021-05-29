public class IsSubsequence
{
    public bool Check(string s, string t)
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