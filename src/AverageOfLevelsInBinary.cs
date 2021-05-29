using System.Collections.Generic;
using System.Linq;

public class AverageOfLevelsInBinary
{
    Dictionary<int, List<double>> levels = new Dictionary<int, List<double>>();

    public IList<double> AverageOfLevels(TreeNode root)
    {
        levels.Add(0, new List<double> { root.val });
        Add(root.left, 0 + 1);
        Add(root.right, 0 + 1);
        return levels.Keys.Select(i => (double)levels[i].Sum() / levels[i].Count).ToArray();
    }

    public void Add(TreeNode node, int level)
    {
        if (node == null)
        {
            return;
        }
        if (levels.ContainsKey(level))
        {
            levels[level].Add(node.val);
        }
        else
        {
            levels.Add(level, new List<double> { node.val });
        }
        Add(node.left, level + 1);
        Add(node.right, level + 1);
    }
}