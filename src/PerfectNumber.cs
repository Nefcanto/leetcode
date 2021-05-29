using System.List.Generics;

public class PerfectNumber {
    public bool CheckPerfectNumber(int num) {
        if (num == 1) {
            return false;
        }
        // find the positive divisers list
        var divisors = new Dictionary<int, int>();
        divisors.Add(1, 0);
        var root = Math.Sqrt(num);
        var x = 2;
        while (x < root) {
            if (num % x == 0) {
                divisors.Add(x, num / x);
            }
            x++;
        }
        if (x * x == num) {
            divisors.Add(x, 0);
        }
        var sum = divisors.Keys.Sum() + divisors.Values.Sum();
        if (sum == num) {
            return true;
        }
        return false;
    }
}