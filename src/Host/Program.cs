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
            var result = new SecondMinimumNodeInABinaryTree().FindSecondMinimumValue(new TreeNode(2, new TreeNode(2), new TreeNode(5, new TreeNode(5), new TreeNode(7))));
        }
    }
}
