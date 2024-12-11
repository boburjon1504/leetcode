public class Solution {
    public int MinimumArea(int[][] grid) {
        int l = -1, r = -1, up = -1, down = -1;

        for(var i = 0; i < grid.Length; i++){
            for(var j = 0; j < grid[i].Length; j++){
                if(grid[i][j] == 1 && l < 0){
                    l = j;
                    r = j;
                    up = i;
                    down = i;
                }else if(grid[i][j] == 1 && j < l){
                    l = j;
                    down = i;
                }else if(grid[i][j] == 1 && r < j){
                    r = j;
                    down = i;
                }else if(grid[i][j] == 1){
                    down = i;
                }
            }

        }
        return (r - l + 1) * (down - up + 1);

    }
}