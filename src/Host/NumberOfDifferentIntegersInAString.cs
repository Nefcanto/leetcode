// not working for => "2393706880236110407059624696967828762752651982730115221690437821508229419410771541532394006597463715513741725852432559057224478815116557380260390432211227579663571046845842281704281749571110076974264971989893607137140456254346955633455446057823738757323149856858154529105301197388177242583658641529908583934918768953462557716z97438020429952944646288084173334701047574188936201324845149110176716130267041674438237608038734431519439828191344238609567530399189316846359766256507371240530620697102864238792350289978450509162697068948604722646739174590530336510475061521094503850598453536706982695212493902968251702853203929616930291257062173c79487281900662343830648295410"
public class Solution
{
    public int NumDifferentIntegers(string word)
    {
        var count = System.Text.RegularExpressions.Regex.Replace(word, "[^0-9]+", " ").Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToInt64(i)).Distinct().Count();
        return count;
    }
}
public class Solution
{
    HashSet<string> numbers = new HashSet<string>();

    public int NumDifferentIntegers(string word)
    {
        var number = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsNumber(word[i]))
            {
                number += word[i].ToString();
            }
            else
            {
                AddNumber(number);
                number = "";
            }
        }
        AddNumber(number);
        return numbers.Count;
    }

    public void AddNumber(string number)
    {
        if (number != "0")
        {
            number = number.TrimStart('0');
        }
        if (number != "" && !numbers.Contains(number))
        {
            numbers.Add(number);
        }
    }
}