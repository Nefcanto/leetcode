using System.Collections.Generic;

public class PathSum
{
    Dictionary<string, int> paths = new Dictionary<string, int>();
    bool found = false;
    int target = 0;
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }
        target = targetSum;
        paths.Add("r", root.val);
        if (root.val == targetSum && root.left == null && root.right == null)
        {
            return true;
        }
        FindPaths(root, "r");
        return found;
    }

    public void FindPaths(TreeNode node, string key)
    {
        if (found)
        {
            return;
        }
        if (node == null)
        {
            return;
        }
        var parentValue = paths[key];
        if (parentValue == target && node.left == null && node.right == null)
        {
            found = true;
        }
        if (node.left != null)
        {
            var leftChildKey = key + "l";
            var val = parentValue + node.left.val;
            paths.Add(leftChildKey, val);
            FindPaths(node.left, leftChildKey);
        }
        if (node.right != null)
        {
            var rightChildKey = key + "r";
            var val = parentValue + node.right.val;
            paths.Add(rightChildKey, val);
            FindPaths(node.right, rightChildKey);
        }
    }
}