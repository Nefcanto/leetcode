using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new OneBitAndTwoBitCharacters().IsOneBitCharacter(new int[] { 1, 0, 0 });
        }
    }
}
