public class Solution {
    public int Rob(int[] nums) {
        var mx = 0;
        for(var i = 0; i < nums.Length; i++){
            var res = Rob(i, nums, new());
            mx = mx < res ? res : mx;
        }
        return mx;
    }

    private int Rob(int i, int[] nums, Dictionary<int, int> memo){
        if(memo.ContainsKey(i)) return memo[i];
        if(i >= nums.Length) return 0;
        if(i == nums.Length - 1) return nums[i];
        var mx = nums[i];
        for(var j = i + 2; j < nums.Length; j++){
            var rob = Rob(j, nums, memo) + nums[i];
            if(mx < rob){
                mx = rob;
            }
        }
        memo[i] = mx;
        return mx;
    }
}