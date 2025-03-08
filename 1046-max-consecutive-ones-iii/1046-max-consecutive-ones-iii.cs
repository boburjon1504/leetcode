public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int l = 0, r = 0, mx = 0;
        var cntZero = 0;
        while(r < nums.Length){
            if(nums[r] == 0){
                if(cntZero >= k){
                    while(nums[l] != 0){
                        l++;
                    }
                    l++;
                }else{
                    cntZero++;
                }
            }

            var val = r - l + 1;

            if(mx < val){
                mx = val;
            }
            r++;
        }

        return mx;
    }
}