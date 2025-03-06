public class Solution {
    public int Rob(int[] nums) {
        var mx = 0;
        for(var i = 0; i < nums.Length; i++){
            var res = Rob(i, nums, new(), i == 0);
            mx = mx < res ? res : mx;
        }
        return mx;
    }
    private int Rob(int i, int[] nums, Dictionary<int, int> memo, bool startWithZeroIndex){
        if(memo.ContainsKey(i)) return memo[i];
        if(i >= nums.Length) return 0;
        if(i == nums.Length - 1) return nums[i];
        var mx = nums[i];
        for(var j = i + 2; j < nums.Length; j++){
            if(startWithZeroIndex && j == nums.Length - 1) continue;

            var rob = Rob(j, nums, memo, startWithZeroIndex) + nums[i];
            if(mx < rob){
                mx = rob;
            }
        }
        memo[i] = mx;
        return mx;
    }
}