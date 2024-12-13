public class Solution {
    public bool WinnerOfGame(string colors) {
        int cA = 0, cB = 0, totalA = 0, totalB = 0;
        
        foreach(var i in colors){
            if(i == 'A'){
                cA++;
                if(cB - 2 > 0){
                    totalB += cB - 2;
                }
                cB = 0;
            }else{
                cB++;
                if(cA - 2 > 0){
                    totalA += cA - 2;
                }
                cA = 0;
            }
        }
        if(cA - 2 > 0){
            totalA += cA - 2;
        }

        if(cB - 2 > 0){
            totalB += cB - 2;
        }
        return totalA > totalB;

    }
}