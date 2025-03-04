public class Solution {
    public int CoinChange(int[] coins, int amount) {
        return Coin(amount, coins, new());
    }
    private int Coin(int amount, int[] coins, Dictionary<int, int> memo){
        if(memo.ContainsKey(amount)) return memo[amount];
        if(amount == 0) return 0;
        if(amount < 0) return -1;
        var min = -1;
        foreach(var c in coins){
            var res = Coin(amount - c, coins, memo);

            if(res < 0) continue;

            if(min < 0 || min > res + 1){
                min = res + 1;
            }
        }
        memo[amount] = min;
        return min;
    }
}