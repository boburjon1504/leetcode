public class Solution {
    public int NumOfPairs(string[] nums, string target) {
        var dict = new Dictionary<string, int>();

        for(var i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = 0;
            }

            dict[nums[i]]++;
        }

        var count = 0;

        foreach(var n in nums){
            if(n == target) continue;

            var i = target.IndexOf(n);

            if(i != 0) continue;

            var sub = target.Substring(n.Length);

            if(!dict.ContainsKey(sub)) continue;

            var ls = dict[sub];
            
            count += (sub == n ? ls - 1 : ls);
        }

        return count;
    }
}