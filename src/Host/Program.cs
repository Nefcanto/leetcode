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
            var result = new MaximumNumberOfNonOverlappingSubarraysWithSumEqualsTarget().MaxNonOverlapping(new int[] { -1, 3, 5, 1, 4, 2, -9 }, 6);
        }
    }
}
