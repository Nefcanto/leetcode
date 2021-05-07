using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new MinimumIndexSumOfTwoLists().FindRestaurant(new string[] { "saeed", "hamid" }, new string[] { "hamid", "saeed", "ali" });
        }
    }
}
