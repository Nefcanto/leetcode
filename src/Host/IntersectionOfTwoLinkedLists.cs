using System.Collections.Generic;

public class IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var distinctA = new HashSet<int>();
        var nodeA = headA;
        var nodeB = headB;
        while (nodeA != null)
        {
            if (!distinctA.Contains(nodeA.val))
            {
                distinctA.Add(nodeA.GetHashCode());
            }
            nodeA = nodeA.next;
        }
        while (nodeB != null)
        {
            if (distinctA.Contains(nodeB.GetHashCode()))
            {
                return nodeB;
            }
            nodeB = nodeB.next;
        }
        return null;
    }
}