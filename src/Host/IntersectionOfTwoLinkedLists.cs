using System.Collections.Generic;

public class IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var distinctA = new HashSet<ListNode>();
        while (headA != null)
        {
            distinctA.Add(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            if (distinctA.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
}