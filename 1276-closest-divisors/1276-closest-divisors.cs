public class Solution {
    public int[] ClosestDivisors(int num) {
        var ans = new int[2];
        var diff = 1_000_000_000_000;
        var num1 = num + 1;
        var num2 = num + 2;
        for(var i = 1; i <= (int)Math.Sqrt(num1); i++){
            if(num1 % i == 0){
                var n = num1 / i;
                var abs = Math.Abs(n - i);
                if(abs < diff){
                    diff = abs;
                    (ans[0], ans[1]) = (n, i);
                }
            }
        }

        for(var i = 1; i <= (int)Math.Sqrt(num2); i++){
            if(num2 % i == 0){
                var n = num2 / i;
                var abs = Math.Abs(n - i);
                if(abs < diff){
                    diff = abs;
                    (ans[0], ans[1]) = (n, i);
                }
            }
        }

        return ans;
    }
}