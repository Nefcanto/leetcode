using System.Collections.Generic;

public class GoalParserInterpretation
{
    public string Interpret(string command)
    {
        var maps = new Dictionary<string, string>();
        maps.Add("G", "G");
        maps.Add("()", "o");
        maps.Add("(al)", "al");
        var token = "";
        var index = 0;
        var result = "";
        while (index < command.Length)
        {
            token = "";
            while (!maps.ContainsKey(token))
            {
                token += command[index].ToString();
                index++;
            }
            result += maps[token];
        }
        return result;
    }
}