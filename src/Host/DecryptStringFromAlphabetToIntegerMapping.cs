using System;

namespace Host
{
    public class DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            var text = "";
            var index = s.Length - 1;
            while (index > -1)
            {
                var @char = s[index];
                if (@char == '#')
                {
                    var part = s.Substring(index - 2, 2);
                    text += ((char)(Convert.ToInt32(part) + 96)).ToString();
                    index -= 3;
                }
                else
                {
                    var part = s[index].ToString();
                    text += ((char)(Convert.ToInt32(part) + 96)).ToString();
                    index--;
                }
            }
            var result = text.ToCharArray();
            Array.Reverse(result);
            return string.Join(' ', result).Replace(" ", "");
        }
    }
}
