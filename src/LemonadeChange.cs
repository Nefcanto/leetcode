// not working either
public class LemonadeChange
{
    public bool Change(int[] bills)
    {
        var sum = 0;
        for (int i = 0; i < bills.Length; i++)
        {
            sum += bills[i];
            sum -= (bills[i] - 5);
            if (sum < 0 || sum % 10 == 0)
            {
                return false;
            }
        }
        return true;
    }
}

// not working
// public class LemonadeChange
// {
//     public bool Change(int[] bills)
//     {
//         var fives = 0;
//         var tens = 0;
//         var twenties = 0;
//         for (int i = 0; i < bills.Length; i++)
//         {
//             if (bills[i] != 5 && fives == 0)
//             {
//                 return false;
//             }
//             if (bills[i] == 5)
//             {
//                 fives++;
//             }
//             else if (bills[i] == 10)
//             {
//                 tens++;
//                 fives--;
//             }
//             else
//             {
//                 if (tens == 0 && fives < 3)
//                 {
//                     return false;
//                 }
//                 twenties++;
//                 if (tens > 1)
//                 {
//                     tens--;
//                     fives--;
//                 }
//                 else
//                 {
//                     fives -= 3;
//                 }
//             }
//         }
//         return true;
//     }
// }