public class Solution
{
    public string MaximumTime(string time)
    {
        var result = time.StartsWith("?") ? "2" : time[0].ToString();
        result += time[1] == '?' ? (result == "2" ? "3" : "9") : time[1].ToString();
        if (result[1] > '3' && time[0] == '?')
        {
            result = "1" + result[1].ToString();
        }
        result += ":";
        result += time[3] == '?' ? "5" : time[3].ToString();
        result += time[4] == '?' ? "9" : time[4].ToString();
        return result;
    }
}