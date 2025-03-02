public class Solution {
    public int Jump(int[] nums) {
        return J(0, nums, new());
    }

    private int J(int i, int[] nums, Dictionary<int, int> memo){
        if(memo.ContainsKey(i)) return memo[i];
        if(i >= nums.Length) return -1;
        if(i == nums.Length - 1) return 0;
        if(nums[i] == 0) return -1;

        var n = 1;
        var mn = -1;
        while(n <= nums[i]){
            var cnt = J(i + n, nums, memo);
            if(cnt >= 0 && (mn > cnt + 1 || mn < 0)){
                mn = cnt + 1;
            }
            n++;
        }
        memo[i] = mn;

        return mn;
    }
}