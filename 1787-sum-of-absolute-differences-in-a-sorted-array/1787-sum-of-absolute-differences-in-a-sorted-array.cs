public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        var n = nums.Length;

        var sm = nums.Sum();
        var ans = new int[n];
        var pref = 0;
        for(var i = 0; i < n; i++){
            ans[i] = nums[i] * i - pref + sm - pref - nums[i] - ((n - i - 1) * nums[i]);

            pref += nums[i];
        }

        return ans;
    }
}