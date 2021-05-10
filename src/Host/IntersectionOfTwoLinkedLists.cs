using System.Collections.Generic;

public class IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var distinctA = new HashSet<int>();
        while (headA != null)
        {
            distinctA.Add(headA.GetHashCode());
            headA = headA.next;
        }
        while (headB != null)
        {
            if (distinctA.Contains(headB.GetHashCode()))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
}