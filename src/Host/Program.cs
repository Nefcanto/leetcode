using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
        }
    }
}
