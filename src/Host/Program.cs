using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new GuessNumberHigherOrLower();
            solution.Target = 50;
            var result = solution.GuessNumber(1000);
        }
    }
}
