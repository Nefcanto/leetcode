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
            new DuplicateZeros().DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
            // 1, 0, 0, 4, 3, 5, 0, 0, 7, 2
        }
    }
}
