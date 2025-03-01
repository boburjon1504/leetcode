public class Solution {
    public int MinPathSum(int[][] grid) {
        return MinPath(grid, grid.Length - 1, grid[0].Length - 1, new Dictionary<string, int>());
    }

    private int MinPath(int[][] grid, int m, int n, Dictionary<string, int> memo){
        var key = $"{m}-{n}";
        if(memo.ContainsKey(key)) return memo[key];
        if(m == 0 && n == 0) return grid[m][n];
        if(m < 0 || n < 0) return 1_000_000;

        var up = grid[m][n] + MinPath(grid, m - 1,n, memo);
        var left = grid[m][n] + MinPath(grid, m, n - 1, memo);
        memo[key] = Math.Min(up, left);
        return memo[key];       
    }

}