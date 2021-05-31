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
            var result = new NumberOfGoodPairs().NumIdenticalPairs(new int[] { 1, 1, 1, 1 });
            Console.ReadLine();
        }
    }
}
