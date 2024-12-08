public class Solution {
    private int[] nums;
    private Random random;
    public Solution(int[] nums) {
        this.nums = nums;
        random = new Random();
    }
    
    public int[] Reset() {
        return nums;
    }
    
    public int[] Shuffle() {
        var set = new HashSet<int>();

        while(set.Count < nums.Length){
            var n = random.Next(nums.Length);
            if(!set.Contains(n)){
                set.Add(n);
            }
        }

        return set.Select(x => nums[x]).ToArray();
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */