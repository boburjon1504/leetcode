public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        var sm = nums.Where(x => (x & 1) == 0).Sum();
        var ans = new int[queries.Length];

        for(var i = 0; i < queries.Length; i++){
            var n = nums[queries[i][1]];
            if((n & 1) == 0){
                sm -= n;
            }
            n += queries[i][0];
            if((n & 1) == 0){
                sm += n;
            }
            nums[queries[i][1]] = n;
            ans[i] = sm;
        }

        return ans;
    }
}