using System.Collections.Generic;

public class UniqueMorseCodeWords
{
    public int UniqueMorseRepresentations(string[] words)
    {
        var map = new Dictionary<char, string>();
        map.Add('a', ".-");
        map.Add('b', "-...");
        map.Add('c', "-.-.");
        map.Add('d', "-..");
        map.Add('e', ".");
        map.Add('f', "..-.");
        map.Add('g', "--.");
        map.Add('h', "....");
        map.Add('i', "..");
        map.Add('j', ".---");
        map.Add('k', "-.-");
        map.Add('l', ".-..");
        map.Add('m', "--");
        map.Add('n', "-.");
        map.Add('o', "---");
        map.Add('p', ".--.");
        map.Add('q', "--.-");
        map.Add('r', ".-.");
        map.Add('s', "...");
        map.Add('t', "-");
        map.Add('u', "..-");
        map.Add('v', "...-");
        map.Add('w', ".--");
        map.Add('x', "-..-");
        map.Add('y', "-.--");
        map.Add('z', "--..");
        var results = new HashSet<string>();
        for (int i = 0; i < words.Length; i++)
        {
            var morse = "";
            for (int j = 0; j < words[i].Length; j++)
            {
                morse += map[words[i][j]];
            }
            if (!results.Contains(morse))
            {
                results.Add(morse);
            }
        }
        return results.Count;
    }
}