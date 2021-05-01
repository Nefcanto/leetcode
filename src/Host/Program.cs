using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new PlusOne().Perform(new int[] { 9, 9, 8 });
        }
    }
}
