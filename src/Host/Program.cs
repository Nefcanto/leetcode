using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(new ListNode { val = 1, next = new ListNode { val = 1, next = new ListNode { val = 2 } } });
        }
    }
}
