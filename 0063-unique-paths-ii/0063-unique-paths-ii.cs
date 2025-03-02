public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        return CountUniquePaths(obstacleGrid, 0, 0, new());
    }

    private int CountUniquePaths(int[][] grid, int i, int j, Dictionary<string, int> memo){
        var key = $"{i},{j}";
        if(memo.ContainsKey(key)) return memo[key];
        if(i == grid.Length || j == grid[0].Length) return 0;
        if(grid[i][j] == 1) return 0;
        if(i == grid.Length - 1 && j == grid[0].Length - 1 && grid[i][j] != 1) return 1;

        memo[key] = CountUniquePaths(grid, i + 1, j, memo) + CountUniquePaths(grid, i, j + 1, memo);

        return memo[key];
    }
}