using System;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
        }
    }
}
