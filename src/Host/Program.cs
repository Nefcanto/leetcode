using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new SymmetricTree().IsSymmetric(new TreeNode(1, new TreeNode(2), new TreeNode(3)));
        }
    }
}
