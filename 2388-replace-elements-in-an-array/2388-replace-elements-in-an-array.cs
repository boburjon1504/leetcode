public class Solution {
    public int[] ArrayChange(int[] nums, int[][] operations) {
        var dc = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++){
            dc[nums[i]] = i;
        }

        foreach(var op in operations){
            var index = dc[op[0]];
            dc.Remove(op[0]);
            nums[index] = op[1];

            dc[op[1]] = index;
        }

        return nums;
    }
}