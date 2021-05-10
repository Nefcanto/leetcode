using System.Collections;

public class CreateTargetArrayInTheGivenOrder
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        var target = new ArrayList(nums.Length);
        for (int i = 0; i < index.Length; i++)
        {
            target.Insert(index[i], nums[i]);
        }
        return (int[])target.ToArray(typeof(int));
    }

    public int[] Faster(int[] nums, int[] index)
    {
        var target = new int[index.Length];
        for (int i = 0; i < index.Length; i++)
        {
            if (i > index[i])
            {
                for (int j = target.Length - 1; j >= index[i]; j--)
                {
                    if (j > 0)
                    {
                        target[j] = target[j - 1];
                    }
                }
            }
            target[index[i]] = nums[i];
        }
        return target;
    }
}