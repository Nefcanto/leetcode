public class Solution {
    public int FindNumbers(int[] nums) {
        return nums.Where(i => i.ToString().Length % 2 == 0).Count();
    }
}