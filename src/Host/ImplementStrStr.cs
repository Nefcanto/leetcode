public class ImplementStrStr
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == null || needle == "")
        {
            return 0;
        }
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (i + j >= haystack.Length)
                    {
                        break;
                    }
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
        }
        return -1;
    }
}