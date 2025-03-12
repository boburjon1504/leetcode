public class Solution {
    public int MaximumCount(int[] nums) {
        
        int l = 0, n = nums.Length, r = n - 1;

        while(l <= r){
            var md = (l + r) / 2;

            if(nums[md] > 0){
                r = md - 1;
            }else{
                l = md + 1;
            }
        }
        var positivesCount = n - l;
        l = 0;
        r = n - 1;

        while(l <= r){
            var md = (l + r) / 2;

            if(nums[md] >= 0){
                r = md - 1;
            }else{
                l = md + 1;
            }
        }

        return  Math.Max(positivesCount, l);
    }
}