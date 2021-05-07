

// slow
//public class Solution
//{
//    public int CountBinarySubstrings(string s)
//    {
//        var num = 1;
//        var oldCount = -1;
//        var count = 0;
//        while (true)
//        {
//            var pattern = "";
//            var mirror = "";
//            for (int i = 1; i <= num; i++)
//            {
//                pattern = "0" + pattern + "1";
//                mirror = "1" + mirror + "0";
//            }
//            var index = 0;
//            while (true)
//            {
//                index = s.IndexOf(pattern, index);
//                if (index > -1)
//                {
//                    count++;
//                }
//                else
//                {
//                    break;
//                }
//                index += num * 2;
//            }
//            index = 0;
//            while (true)
//            {
//                index = s.IndexOf(mirror, index);
//                if (index > -1)
//                {
//                    count++;
//                }
//                else
//                {
//                    break;
//                }
//                index += num * 2;
//            }
//            if (oldCount == count)
//            {
//                break;
//            }
//            oldCount = count;
//            num++;
//        }
//        return count;
//    }
//}

// slow
//using System.Text.RegularExpressions;

//public class Solution
//{
//    public int CountBinarySubstrings(string s)
//    {
//        var oldCount = 0;
//        int count = 0;
//        int num = 1;
//        while (true)
//        {
//            var pattern = "";
//            for (int i = 1; i <= num; i++)
//            {
//                pattern = "0" + pattern + "1";
//            }
//            var regex = new Regex(pattern);
//            count += regex.Matches(s).Count;
//            pattern = "";
//            for (int i = 1; i <= num; i++)
//            {
//                pattern = "1" + pattern + "0";
//            }
//            regex = new Regex(pattern);
//            count += regex.Matches(s).Count;
//            if (oldCount == count)
//            {
//                break;
//            }
//            oldCount = count;
//            num++;
//        }
//        return count;
//    }
//}