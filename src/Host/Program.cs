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
            var result = new SortArrayByParity().NotInPlaceButFast(new int[] { 1, 3, 2, 4, 4, 2, 3, 4, 6, 44, 5, 6 });
        }
    }
}
