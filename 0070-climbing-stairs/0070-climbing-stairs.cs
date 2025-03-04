public class Solution {
    public int ClimbStairs(int n) {
        return Climb(n, new());
    }

    private int Climb(int n, Dictionary<int, int> memo){
        if(memo.ContainsKey(n)) return memo[n];
        if(n == 0) return 1;
        if(n < 0) return -1;
        var comb = new int[]{ 
            Climb(n - 1, memo), 
            Climb(n - 2, memo)}.Where(x => x > 0).ToArray();

        if(comb.Length == 0){
            memo[n] = 0;
            return 0;
        }


        memo[n] = comb.Sum();
        return memo[n];
    }
}