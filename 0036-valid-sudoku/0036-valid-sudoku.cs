public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var dc = new Dictionary<char, IList<IList<int>>>();

        for(var i = 0; i < board.Length; i++){
            for(var j = 0; j < board.Length; j++){
                if(!char.IsDigit(board[i][j])){
                    continue;
                }
                if(!dc.ContainsKey(board[i][j])){
                    dc[board[i][j]] = new List<IList<int>>{
                        new List<int>{ i, j }
                    };
                }else{
                    foreach(var loc in dc[board[i][j]]){
                        if(loc[0] == i || loc[1] == j || (loc[0] / 3 == i /3 && loc[1] / 3 == j / 3)){
                            return false;
                        }
                    }
                    dc[board[i][j]].Add([i,j]);
                }

            }
        }

        return true;
    }
}