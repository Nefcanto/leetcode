using System.Collections.Generic;

public class CousinsInBinaryTree
{
    Dictionary<int, string> dic = new Dictionary<int, string>();

    public bool IsCousins(TreeNode root, int x, int y)
    {
        dic.Add(root.val, "r");
        AddNode(root.left, "r", "l");
        AddNode(root.right, "r", "r");
        if (dic[x].Length == dic[y].Length)
        {
            var xParent = dic[x].Substring(0, dic[x].Length - 1);
            var yParent = dic[y].Substring(0, dic[y].Length - 1);
            if (xParent == yParent)
            {
                return false;
            }
            return true;
        }
        return false;
    }

    public void AddNode(TreeNode node, string parentKey, string nodeKey)
    {
        if (node == null)
        {
            return;
        }
        dic.Add(node.val, parentKey + nodeKey);
        AddNode(node.left, parentKey + nodeKey, "l");
        AddNode(node.right, parentKey + nodeKey, "r");
    }
}