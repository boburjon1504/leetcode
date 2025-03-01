public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        var min = 1_000_000;
        var memo = new Dictionary<string, int>();
        for(var i = 0; i < matrix.Length; i++){
            var res = GetMin(matrix, 0, i, memo);
            if(min > res){
                min = res;
            }

        }
        return min;
    }

    private int GetMin(int[][] matrix, int i, int j, Dictionary<string, int> memo){
        var key = $"{i},{j}";
        if(memo.ContainsKey(key)) return memo[key];
        if(i == matrix.Length || j == matrix.Length || j < 0) return -101;
        if(i == matrix.Length - 1){
            memo[key] = matrix[i][j];
            return memo[key];
        }

        var mins = new int[]{ 
            GetMin(matrix, i + 1, j, memo), 
            GetMin(matrix, i + 1, j - 1, memo), 
            GetMin(matrix, i + 1, j + 1, memo)
        };
        var existMin = mins.Where(x => x != -101).ToArray();
        var length = existMin.Length;
        if(length == 0){
            memo[key] = -1;
        }else{
            memo[key] = matrix[i][j] + existMin.Min();
        }

        return memo[key];
    }
}