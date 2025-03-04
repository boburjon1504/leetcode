public class Solution {
    public int IntegerBreak(int n) {
        var arr = Enumerable.Range(1, n).ToArray();
        return Max(n, 0, arr, new());
    }

    private int Max(int n, int k, int[] arr, Dictionary<int, int> memo){
        if(memo.ContainsKey(n)) return memo[n];
        if(n == 0 && k >= 2) return 1;
        if(n < 0 || (n == 0 && k < 2)) return 0;
        var mx = 0;
        foreach(var i in arr){
            var prod = Max(n - i, k + 1, arr, memo) * i;

            if(mx < prod){
                mx = prod;
            }
        }

        memo[n] = mx;

        return mx;
    }
}