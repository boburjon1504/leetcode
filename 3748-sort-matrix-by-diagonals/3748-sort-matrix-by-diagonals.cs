public class Solution {
    private int[][] grid;
    public int[][] SortMatrix(int[][] grid) {
        this.grid = grid;
        BottomDiagonals();
        TopDiagonals();
        return grid;
        
    }
    private void TopDiagonals(){
        var n = grid.Length;
        for(var i = 1; i < n; i++){
            int r = 0, c = i;
            var ls = new List<(int r, int c)>();
            while(c < n){
                ls.Add((r, c));
                r++;
                c++;
            }
            SortAscending(ls);
        }
    }
    private void SortAscending(IList<(int r, int c)> arr){
        for(var i = 0; i < arr.Count - 1; i++){
            for(var j = i; j < arr.Count; j++){
                var (r, c) = arr[i];
                var (a, b) = arr[j];

                if(grid[r][c] > grid[a][b]){
                    (grid[r][c], grid[a][b]) = (grid[a][b], grid[r][c]);
                }
            }
        }
    }
    private void BottomDiagonals(){
        var n = grid.Length;
        for(var i = 0; i < n; i++){
            int a = i, b = 0;
            var ls = new List<(int x, int y)>();
            while(a < n){
                ls.Add((a, b));
                a++;
                b++;
            }
            SortDescending(ls);
        }
    }

    private void SortDescending(IList<(int x, int y)> arr){
        for(var i = 0; i < arr.Count - 1; i++){
            for(var j = i; j < arr.Count; j++){
                var (a,b) = arr[i];
                var (x, y) = arr[j];

                if(grid[a][b] < grid[x][y]){
                    (grid[a][b], grid[x][y]) = (grid[x][y], grid[a][b]) ;
                }
            }
        }
    }
}