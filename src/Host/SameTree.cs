public class SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return IsSameNode(p, q);
    }

    public bool IsSameNode(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }
        if (p == null && q != null)
        {
            return false;
        }
        if (p != null && q == null)
        {
            return false;
        }
        if (p.val != q.val)
        {
            return false;
        }
        if (p.left != null && q.left == null)
        {
            return false;
        }
        if (p.left == null && q.left != null)
        {
            return false;
        }
        if (p.right != null && q.right == null)
        {
            return false;
        }
        if (p.right == null && q.right != null)
        {
            return false;
        }
        if (p.left == null && q.left == null)
        {
            return IsSameNode(p.right, q.right);
        }
        if (p.right == null && q.right == null)
        {
            return IsSameNode(p.left, q.left);
        }
        return IsSameNode(p.left, q.left) && IsSameNode(p.right, q.right);
    }
}