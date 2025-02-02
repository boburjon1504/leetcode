public class Solution {
    public bool JudgeSquareSum(int c) {
        if(c < 3) return true;

        for(var i = 0; i <= (int)Math.Sqrt(c) + 1; i++){
            var b = Math.Sqrt(c - i * i);
            if((int)b == b){
                return true;
            }
        }

        return false;
    }
}