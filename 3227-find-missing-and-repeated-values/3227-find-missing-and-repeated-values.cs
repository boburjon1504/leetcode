public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        var freq = new Dictionary<int, int>();
        var n = grid.Length;
        for(var i = 0; i < n; i++){
            for(var j = 0; j < n; j++){
                if(!freq.ContainsKey(grid[i][j])){
                    freq[grid[i][j]] = 0;
                }

                freq[grid[i][j]]++;
            }
        }
        int a = 0, b = 0;
        for(var i = 1; i <= n * n; i++){
            if(!freq.ContainsKey(i)){
                b = i;
            }else if(freq[i] == 2){
                a = i;
            }
        }

        return [a, b];
    }
}