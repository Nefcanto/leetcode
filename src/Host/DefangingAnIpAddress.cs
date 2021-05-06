public class DefangingAnIpAddress
{
    public string DefangIPaddr(string address)
    {
        //return address.Replace(".", "[.]");
        var cursor = 0;
        while (cursor < address.Length)
        {
            var pointIndex = address.IndexOf(".", cursor);
            if (pointIndex == -1)
            {
                break;
            }
            address = address.Insert(pointIndex, "[");
            address = address.Insert(pointIndex + 2, "]");
            cursor = pointIndex + 2;
        }
        return address;
    }
}