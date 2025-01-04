public class Solution {
    public char[][] RotateTheBox(char[][] boxGrid) {
        var ans = new char[boxGrid[0].Length]
                            .Select( _ => new char[boxGrid.Length]
                                                    .Select( _ => '.').ToArray()).ToArray();

        for(var i = 0; i < boxGrid.Length; i++){
            var stoneCount = 0;
            for(var j = 0; j < boxGrid[0].Length; j++){
                if(boxGrid[i][j] == '#'){
                    stoneCount++;
                }else if(boxGrid[i][j] == '*'){
                    var a = j - 1;
                    while(stoneCount > 0){
                        ans[a][boxGrid.Length - 1 - i] = '#';
                        a--;
                        stoneCount--;
                    }
                    ans[j][boxGrid.Length - 1 - i] = '*';
                }
            }
            var b = boxGrid[0].Length - 1;
            while(stoneCount > 0){
                ans[b][boxGrid.Length - 1 - i] = '#';
                b--;
                stoneCount--;
            }
        }

        return ans;
    }
}