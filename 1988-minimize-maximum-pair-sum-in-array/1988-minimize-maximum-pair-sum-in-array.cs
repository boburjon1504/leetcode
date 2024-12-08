public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        var mx = 0;
        int i = 0, j = nums.Length - 1;

        while(i < j){
            var sm = nums[i] + nums[j];
            if(sm > mx){
                mx = sm;
            }
            i++;
            j--;
        }

        return mx;
    }
}