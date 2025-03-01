public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        return GetMin(triangle, 0, 0, new());
    }

    private int GetMin(IList<IList<int>> triangle, int i, int j, Dictionary<string, int> memo){
        var key = $"{i},{j}";
        if(memo.ContainsKey(key)) return memo[key];
        if(i == triangle.Count || j == triangle[i].Count) return -1_000_000;
        if(i == triangle.Count - 1) return triangle[i][j];

        var down = GetMin(triangle, i + 1, j, memo);
        var left = GetMin(triangle, i + 1, j + 1, memo);
        if(down == -1_000_000 && left == -1_000_000){
            memo[key] = -1_000_000;
        }else
        if(down == -1_000_000 || left == -1_000_000){
            memo[key] = triangle[i][j] + Math.Max(down, left);
        }else{
            memo[key] = triangle[i][j] + Math.Min(down, left);
        }

        return memo[key];
    }
}