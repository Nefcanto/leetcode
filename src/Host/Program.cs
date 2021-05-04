using System;
using System.Diagnostics;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().IsSameTree(new TreeNode(0, new TreeNode(-5)), new TreeNode(0, new TreeNode(-8)));
        }
    }
}
