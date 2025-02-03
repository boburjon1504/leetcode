public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        var isIncreasing = true;
        int cntInc = 1, cntDec = 1;
        var mx = 1;
        for(var i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i - 1]){
                cntInc++;
                cntDec = 1;
            }else if(nums[i] == nums[i - 1]){
                cntInc = 1;
                cntDec = 1;
            }else{
                cntDec++;
                cntInc = 1;
            }

            if(cntInc > mx){
                mx = cntInc;
            }
            if(cntDec > mx){
                mx = cntDec;
            }
        }

        return mx;
    }
}