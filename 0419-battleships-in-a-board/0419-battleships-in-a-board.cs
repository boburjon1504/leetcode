public class Solution {
    public int CountBattleships(char[][] board) {
        var set = new HashSet<string>();

        var cnt = 0;

        for(var i = 0; i < board.Length; i++){
            for(var j = 0; j < board[i].Length; j++){
                var val = $"{i}-{j}";
                if(board[i][j] == 'X' && set.Contains(val)){
                    continue;
                }

                if(board[i][j] == 'X'){
                    set.Add($"{i}-{j}");
                    cnt++;
                    var a = j;
                    while(a < board[i].Length && board[i][a] == 'X'){
                        set.Add($"{i}-{a}");
                        a++;
                    }

                    a = i;

                    while(a < board.Length && board[a][j] == 'X'){
                        set.Add($"{a}-{j}");
                        a++;
                    }
                }
            }
        }

        return cnt;
    }
}