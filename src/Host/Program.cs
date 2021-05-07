using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new PartitionArrayIntoThreePartsWithEqualSum().CanThreePartsEqualSum(new int[] { -5, 9, 7, -5, -9, 10, 8, 7, -2, 1, -3, 1, -6, -7, -5, -9, -2, -6, 2, -4, -8, -7, 1, -5, 9, 9, 3, 7, -3, -2, -3, -6, 7, -7, -4, -8, 10, 1, -9, 4, -7, 5, 7, 6, -2 });
        }
    }
}
