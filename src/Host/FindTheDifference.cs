using System.Linq;

public class FindTheDifference
{
    public char Find(string s, string t)
    {
        for (int i = 0; i < t.Length; i++)
        {
            var index = s.IndexOf(t[i].ToString());
            if (index == -1)
            {
                return t[i];
            }
            s = s.Remove(index, 1);
        }
        return t.Last();
    }
}