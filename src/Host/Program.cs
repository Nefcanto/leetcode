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
            var result = new MinimumCostToMoveChipsToTheSamePosition().MinCostToMoveChips(new int[] { 6, 4, 7, 8, 2, 10, 2, 7, 9, 7 });
        }
    }
}
