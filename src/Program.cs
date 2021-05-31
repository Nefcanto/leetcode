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
            var result = new EvaluateReversePolishNotation().EvalRPN(new string[] { "2", "1", "+", "3", "*" });
            Console.ReadLine();
        }
    }
}
