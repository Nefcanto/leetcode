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
            var result = new PartitionArrayIntoThreePartsWithEqualSum().CanThreePartsEqualSum(File.ReadAllText(@"C:\Temp\Numbers.txt").Split(',').Select(i => Convert.ToInt32(i)).ToArray());
        }
    }
}
