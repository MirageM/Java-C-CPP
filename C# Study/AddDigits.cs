// LeetCode: 258. Add Digits
// Time Complexity: O(1) Space Complexity: O(1)
public class Solution {
    public int AddDigits(int num) {
        if (num == 0)
        {
            return 0;
        }
        int ans = num % 9;
        return ans == 0 ? 9: ans;
    }
}