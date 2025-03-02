public class Solution {
    public bool CanJump(int[] nums) {
        return Can(0, nums, new());
    }
    private bool Can(
        int i, int[] nums, Dictionary<int,bool> memo){
        if(memo.ContainsKey(i)) return memo[i];
        if(i >= nums.Length - 1) return true;
        if(nums[i] == 0) return false;
        var n = 1;
        while(n <= nums[i]){
            if(Can(n + i, nums, memo)){
                memo[i] = true;
                return true;
            }
            n++;
        }
        memo[i] = false;

        return false;
    }
}