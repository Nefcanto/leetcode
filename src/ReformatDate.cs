using System.Collections.Generic;

public class ReformatDate
{
    static Dictionary<string, string> months = new Dictionary<string, string>();

    static ReformatDate()
    {
        months.Add("Jan", "01");
        months.Add("Feb", "02");
        months.Add("Mar", "03");
        months.Add("Apr", "04");
        months.Add("May", "05");
        months.Add("Jun", "06");
        months.Add("Jul", "07");
        months.Add("Aug", "08");
        months.Add("Sep", "09");
        months.Add("Oct", "10");
        months.Add("Nov", "11");
        months.Add("Dec", "12");
    }

    public string Reformat(string date)
    {
        var parts = date.Split(' ');
        var day = parts[0].Substring(0, parts[0].Length - 2).PadLeft(2, '0');

        return $"{parts[2]}-{months[parts[1]]}-{day}";
    }
}