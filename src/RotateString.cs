public class RotateString
{
    public bool Rotate(string s, string goal)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.IsNullOrEmpty(goal);
        }
        if (s.Length != goal.Length)
        {
            return false;
        }
        var count = 0;
        while (count < s.Length)
        {
            s = s.Substring(1) + s[0].ToString();
            if (s == goal)
            {
                return true;
            }
            count++;
        }
        return false;
    }
}