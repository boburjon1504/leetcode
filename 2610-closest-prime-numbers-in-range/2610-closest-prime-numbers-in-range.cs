public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        
        int num1 = -1, num2 = -1;
        var pair = new int[2];
        for(var i = left; i <= right; i++){
            if(!IsPrime(i)) continue;

            (pair[0], pair[1]) = (pair[1], i);
            if(pair[1] - pair[0] <=2 && pair[0] != 0)return pair;

            if(num1 == -1){
                num1 = i;
            }else if(num2 == -1){
                num2 = i;
            }else if(num2 - num1 > pair[1] - pair[0]){
                (num1, num2) = (pair[0], pair[1]);
            }
        }
        if(num1 < 0 || num2 < 0) return [-1,-1];
        return [num1, num2];
    }

    private bool IsPrime(int n){
        if(n <=1) return false;

        if(n == 2) return true;

        if(n % 2 == 0) return false;

        for(var i = 3; i < (int)Math.Sqrt(n) + 1; i++){
            if(n % i == 0) return false;
        }

        return true;
    }
}