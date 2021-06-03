using System.Collections.Generic;
using System.Linq;

public class Solution
{
    List<int> sorted = new List<int>();
    public TreeNode IncreasingBST(TreeNode root)
    {
        sorted.Add(root.val);
        AddChildren(root.left);
        AddChildren(root.right);
        sorted = sorted.OrderBy(i => i).ToList();
        var newRoot = new TreeNode();
        var right = new TreeNode();
        var temp = newRoot;
        newRoot.right = right;
        foreach (var item in sorted)
        {
            right = new TreeNode();
            right.val = item;
            temp.right = right;
            temp = right;
        }
        return newRoot.right;
    }

    public void AddChildren(TreeNode node)
    {
        if (node == null)
        {
            return;
        }
        sorted.Add(node.val);
        AddChildren(node.left);
        AddChildren(node.right);
    }
}