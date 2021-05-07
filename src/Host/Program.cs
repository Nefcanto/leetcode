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
            var result = new ImageSmoother().MakeSmooth(new int[][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7 }, new int[] { 8, 9, 10 }, new int[] { 11, 12, 13 }, new int[] { 14, 15, 16 } });
        }
    }
}
