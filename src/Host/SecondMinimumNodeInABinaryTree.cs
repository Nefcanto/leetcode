using System.Collections.Generic;
using System.Linq;

public class SecondMinimumNodeInABinaryTree
{
    HashSet<int> values = new HashSet<int>();
    public int FindSecondMinimumValue(TreeNode root)
    {
        values.Add(root.val);
        Find(root.left);
        Find(root.right);
        if (values.Count > 1)
        {
            return values.ToList().OrderBy(i => i).Skip(1).Take(1).ToList()[0];
        }
        return -1;
    }

    public void Find(TreeNode node)
    {
        if (node == null)
        {
            return;
        }
        if (values.Contains(node.val))
        {
            Find(node.left);
            Find(node.right);
        }
        else
        {
            values.Add(node.val);
        }
    }
}