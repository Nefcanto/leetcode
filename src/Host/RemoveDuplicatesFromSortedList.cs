using System.Collections.Generic;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var uniqueList = new List<int>();
        var node = head;
        while (node != null)
        {
            if (!uniqueList.Contains(node.val))
            {
                uniqueList.Add(node.val);
            }
            node = node.next;
        }
        ListNode result = null;
        for (int i = uniqueList.Count - 1; i >= 0; i--)
        {
            if (result == null)
            {
                result = new ListNode { val = uniqueList[i] };
            }
            else
            {
                node = new ListNode { val = uniqueList[i] };
                node.next = result;
                result = node;
            }
        }
        return result;
    }
}