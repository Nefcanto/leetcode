public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        return IsSymmetric(root, root);
    }

    public bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
        {
            return true;
        }
        if (left == null || right == null)
        {
            return false;
        }
        if (left.val == right.val)
        {
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
        else
        {
            return false;
        }
    }
}