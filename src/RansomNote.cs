using System.Collections.Generic;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var chars = ransomNote.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            var index = magazine.IndexOf(chars[i].ToString());
            if (index == -1)
            {
                return false;
            }
            magazine = magazine.Remove(index, 1);
        }
        return true;
    }

    public bool CanConstructFaster(string ransomNote, string magazine)
    {
        var magSet = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            if (magSet.ContainsKey(magazine[i]))
            {
                magSet[magazine[i]]++;
            }
            else
            {
                magSet.Add(magazine[i], 1);
            }
        }
        var ranSet = new Dictionary<char, int>();
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (ranSet.ContainsKey(ransomNote[i]))
            {
                ranSet[ransomNote[i]]++;
            }
            else
            {
                ranSet.Add(ransomNote[i], 1);
            }
        }
        foreach (var key in ranSet.Keys)
        {
            if (!magSet.ContainsKey(key))
            {
                return false;
            }
            if (ranSet[key] > magSet[key])
            {
                return false;
            }
        }
        return true;
    }
}