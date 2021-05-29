using System.Collections.Generic;
using System.Linq;

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var values = new List<int>();
        if (l1 != null)
        {
            do
            {
                values.Add(l1.val);
                l1 = l1.next;
            } while (l1 != null);
        }
        if (l2 != null)
        {
            do
            {
                values.Add(l2.val);
                l2 = l2.next;
            } while (l2 != null);
        }
        if (values.Count == 0)
        {
            return null;
        }
        values = values.OrderBy(i => i).ToList();
        var result = new ListNode();
        var temp = new ListNode();
        temp = result;
        for (int i = 0; i < values.Count; i++)
        {
            result.val = values[i];
            if (i != values.Count - 1)
            {
                result.next = new ListNode();
                result = result.next;
            }
        }
        return temp;
    }
}