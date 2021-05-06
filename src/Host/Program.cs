using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new ValidPalindrome().IsPalindrome("A man, a plan, a canal: Panama");
        }
    }
}
