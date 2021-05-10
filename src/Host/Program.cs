using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().GetIntersectionNode(new ListNode(4, new ListNode(1, new ListNode(8, new ListNode(4, new ListNode(5))))), new ListNode(5, new ListNode(6, new ListNode(1, new ListNode(8, new ListNode(4, new ListNode(5)))))));
        }
    }
}
