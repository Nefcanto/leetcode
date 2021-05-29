using System.Collections.Generic;
using System.Linq;

public class MinStack
{
    int? min = null;
    List<int> numbers = new List<int>();

    /** initialize your data structure here. */
    public MinStack()
    {

    }

    public void Push(int val)
    {
        if (min == null)
        {
            min = val;
        }
        if (val < min)
        {
            min = val;
        }
        numbers.Add(val);
    }

    public void Pop()
    {
        numbers.RemoveAt(numbers.Count - 1);
    }

    public int Top()
    {
        return numbers.Last();
    }

    public int GetMin()
    {
        return numbers.Min();
    }
}