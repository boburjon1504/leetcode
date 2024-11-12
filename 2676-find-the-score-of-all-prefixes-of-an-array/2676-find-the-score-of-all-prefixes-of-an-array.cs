public class Solution {
    public long[] FindPrefixScore(int[] nums) {
        long[] ans = new long[nums.Length];
        ans[0] = nums[0] * 2;
        var mx = nums[0];
        for(var i = 1; i < nums.Length; i++){
            if(mx < nums[i]){
                mx = nums[i];
            }

            ans[i] = ans[i - 1] + mx + nums[i];
        }

        return ans;
    }
}