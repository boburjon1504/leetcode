public class Solution {
    public int LongestSubarray(int[] nums) {
        var mx = 0;

        int l = 0, r = 0;
        bool hasZero = false;

        while(r < nums.Length){
            if(nums[r] == 0){
                if(hasZero){
                    while(nums[l] != 0){
                        l++;
                    }
                    l++;
                }

                hasZero = true;
            }
            var len = r - l + (hasZero ? 0 : 1);

            if(mx < len){
                mx = len;
            }
            r++;
        }
        
        return hasZero ? mx : mx - 1;
    }
}