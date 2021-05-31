using System;
using System.Collections.Generic;
using System.Linq;

public class GroupAnagrams
{
    // slow
    public IList<IList<string>> Group(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var chars = string.Join(',', strs[i].ToCharArray().OrderBy(i => i).ToArray());
            if (anagrams.ContainsKey(chars))
            {
                anagrams[chars].Add(strs[i]);
            }
            else
            {
                anagrams.Add(chars, new List<string> { strs[i] });
            }
        }
        var result = new List<string[]>();
        foreach (var key in anagrams.Keys)
        {
            result.Add(anagrams[key].ToArray());
        }
        return result.ToArray();
    }
}