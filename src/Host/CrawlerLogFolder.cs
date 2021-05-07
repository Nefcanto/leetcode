public class CrawlerLogFolder
{
    public int MinOperations(string[] logs)
    {
        var depth = 0;
        for (int i = 0; i < logs.Length; i++)
        {
            if (logs[i] == "../")
            {
                depth -= depth != 0 ? 1 : 0;
            }
            else if (logs[i] == "./")
            {

            }
            else
            {
                depth++;
            }
        }
        return depth;
    }
}