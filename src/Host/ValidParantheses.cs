using System.Collections.Generic;

public class ValidParantheses
{
    public bool IsValid(string text)
    {
        var openings = new Stack<char>();
        if (text.EndsWith("(") || text.EndsWith("{") || text.EndsWith("["))
        {
            return false;
        }
        if (text.StartsWith(")") || text.StartsWith("}") || text.StartsWith("]"))
        {
            return false;
        }
        for (int i = 0; i < text.Length; i++)
        {
            var @char = text[i];
            if (@char == '(' || @char == '{' || @char == '[')
            {
                openings.Push(@char);
            }
            if (@char == ')' || @char == '}' || @char == ']')
            {
                if (openings.Count == 0)
                {
                    return false;
                }
                var lastOpening = openings.Pop();
                if (@char == ')' && lastOpening != '(')
                {
                    return false;
                }
                if (@char == '}' && lastOpening != '{')
                {
                    return false;
                }
                if (@char == ']' && lastOpening != '[')
                {
                    return false;
                }
            }
        }
        if (openings.Count > 0)
        {
            return false;
        }
        return true;
    }
}