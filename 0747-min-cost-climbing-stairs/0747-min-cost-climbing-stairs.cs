public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        return Math.Min(Min(0, cost, new()), Min(1, cost, new()));
    }

    private int Min(int i, int[] cost, Dictionary<int, int> memo){
        if(memo.ContainsKey(i)) return memo[i];
        if(i >= cost.Length){
            return 0;
        }

        memo[i] = Math.Min(Min(i + 2, cost, memo), Min(i + 1, cost, memo)) + cost[i];
        return memo[i];
    }
}