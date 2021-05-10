using System.Collections.Generic;

// not working, because I didn't understand the problem correctly
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var distinctA = new Dictionary<int, int>();
        var index = 0;
        var nodeA = headA;
        var nodeB = headB;
        while (nodeA != null)
        {
            if (!distinctA.ContainsKey(nodeA.val))
            {
                distinctA.Add(nodeA.val, index);
            }
            nodeA = nodeA.next;
            index++;
        }
        index = 0;
        while (nodeB != null)
        {
            if (distinctA.ContainsKey(nodeB.val) && distinctA[nodeB.val] <= index)
            {
                return nodeB;
            }
            nodeB = nodeB.next;
            index++;
        }
        return null;
    }
}