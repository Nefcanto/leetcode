using System;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 0, 1, 3, 9, 1, 5, 1, 1, 7 };
            var result = new RemoveElement().Remove(nums, 1);
        }
    }
}
