public class UniqueEmailAddresses
{
    public int NumUniqueEmails(string[] emails)
    {
        var recipients = new HashSet<string>();
        for (int i = 0; i < emails.Length; i++)
        {
            var address = emails[i];
            var parts = address.Split('@');
            address = parts[0].Replace(".", "").Split('+')[0] + "@" + parts[1];
            if (!recipients.Contains(address))
            {
                recipients.Add(address);
            }
        }
        return recipients.Count;
    }
}