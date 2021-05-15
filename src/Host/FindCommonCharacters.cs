using System.Collections.Generic;

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        var letters = new List<string>();
        var minWord = words[0];
        var minLength = words[0].Length;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < minLength)
            {
                minLength = words[i].Length;
                minWord = words[i];
            }
        }
        for (int i = 0; i < minWord.Length; i++)
        {
            var has = true;
            for (int j = 0; j < words.Length; j++)
            {
                var index = words[j].IndexOf(minWord[i].ToString());
                if (index == -1)
                {
                    has = false;
                    break;
                }
                words[j] = words[j].Remove(index, 1);
            }
            if (has)
            {
                letters.Add(minWord[i].ToString());
            }
        }
        return letters;
    }
}