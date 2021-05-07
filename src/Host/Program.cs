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
            var result = new CrawlerLogFolder().MinOperations(new string[] { "d1/", "d2/", "../", "d21/", "./" });
        }
    }
}
