using System;
using System.Collections.Generic;

public class ConvertBinaryNumberInALinkedListToInteger
{
    public int GetDecimalValue(ListNode head)
    {
        var binary = new List<int>();
        while (head != null)
        {
            binary.Add(head.val);
            head = head.next;
        }
        var @decimal = 0;
        for (int i = binary.Count - 1; i >= 0; i--)
        {
            @decimal += binary[i] * (int)Math.Pow((double)2, (double)binary.Count - 1 - i);
        }
        return @decimal;
    }
}