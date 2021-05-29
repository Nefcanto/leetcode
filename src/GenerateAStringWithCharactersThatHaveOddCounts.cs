public class Solution {
    public string GenerateTheString(int n) {
        if (n % 2 == 0) {
            return string.Join("", Enumerable.Range(0, n - 1).Select(i => "a")) + "b";
        }
        return string.Join("", Enumerable.Range(0, n).Select(i => "a"));
    }
}