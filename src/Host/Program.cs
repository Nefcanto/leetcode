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
            var result = new MaximumUnitsOnATruck().MaximumUnits(new int[][] { new int[] { 5, 10 }, new int[] { 2, 5 }, new int[] { 4, 7 }, new int[] { 3, 9 } }, 10);
        }
    }
}
