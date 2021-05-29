public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var start = 0;
        var end = s.Length - 1;
        while (start <= end)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
                continue;
            }
            if (s[start].ToString().ToLower() != s[end].ToString().ToLower())
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}

// slower
//public class ValidPalindrome
//{
//    public bool IsPalindrome(string s)
//    {
//        var forward = "";
//        var backward = "";
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (char.IsLetterOrDigit(s[i]))
//            {
//                forward += s[i].ToString().ToLower();
//            }
//        }
//        for (int i = forward.Length - 1; i >= 0; i--)
//        {
//            backward += forward[i].ToString();
//        }
//        return forward == backward;
//    }
//}