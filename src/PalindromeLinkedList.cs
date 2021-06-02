using System.Collections.Generic;

public class PalindromeLinkedList
{
    public bool IsPalindrome(ListNode head)
    {
        var values = new List<int>();
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }
        for (int i = 0, j = values.Count - 1; i <= j; i++, j--)
        {
            if (values[i] != values[j])
            {
                return false;
            }
        }
        return true;
    }
}