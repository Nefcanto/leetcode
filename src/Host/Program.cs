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
            var result = new Solution().IsBoomerang(new int[][] { new int[] { 1, 1 }, new int[] { 2, 2, }, new int[] { 7, 7 } });
        }
    }
}
