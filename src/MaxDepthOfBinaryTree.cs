/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class MaxDepthOfBinaryTree_NotWorking
{
    static int nodesCount = 0;

    public int MaxDepth(TreeNode root)
    {
        Augment(root);
        var depth = 0;
        while (nodesCount >= 2)
        {
            depth++;
            nodesCount = nodesCount / 2;
        }
        return depth;
    }

    public void Augment(TreeNode node)
    {
        if (node == null)
        {
            nodesCount += 1;
            return;
        }
        nodesCount += 1;
        Augment(node.left);
        Augment(node.right);
    }
}