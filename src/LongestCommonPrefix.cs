public class LongestCommonPrefix
{
    public string Find(string[] inputs)
    {
        var index = 0;
        var longestCommonPrefix = "";
        while (true)
        {
            if (inputs[0].Length < index + 1)
            {
                return longestCommonPrefix;
            }
            var lastChar = inputs[0][index];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i].Length < index + 1)
                {
                    return longestCommonPrefix;
                }
                if (inputs[i][index] != lastChar)
                {
                    return longestCommonPrefix;
                }
            }
            longestCommonPrefix += lastChar;
            index++;
        }
    }
}