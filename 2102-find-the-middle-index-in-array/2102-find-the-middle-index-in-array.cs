public class Solution {
    public int FindMiddleIndex(int[] nums) {
        var sum = nums.Sum();

        var pref = 0;

        for(var i = 0; i < nums.Length; i++){
            if(sum - nums[i] - pref == pref){
                return i;
            }

            pref += nums[i];
        }

        return -1;
    }
}