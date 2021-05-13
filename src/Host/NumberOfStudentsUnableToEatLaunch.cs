using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class NumberOfStudentsUnableToEatLaunch
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var queue = new Queue();
        var stack = new Stack();
        var dic = new Dictionary<int, int>();
        dic.Add(0, 0);
        dic.Add(1, 0);
        for (int i = sandwiches.Length - 1; i >= 0; i--)
        {
            stack.Push(sandwiches[i]);
        }
        for (int i = 0; i < students.Length; i++)
        {
            queue.Enqueue(students[i]);
            dic[students[i]]++;
        }
        do
        {
            var sandwich = (int)stack.Peek();
            var preference = (int)queue.Peek();
            if (preference == sandwich)
            {
                stack.Pop();
                queue.Dequeue();
                dic[preference]--;
            }
            else
            {
                queue.Dequeue();
                queue.Enqueue(preference);
                if (dic[sandwich] == 0)
                {
                    break;
                }
            }
        }
        while (stack.Count > 0);
        return queue.Count;
    }
}