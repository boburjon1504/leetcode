public class Solution {
    public int Clumsy(int n) {
        var ans = -1;
        var c = 0;
        var num = 0;
        for(var i = n; i > 0; i--){
            if(c == 0){
                num = i;
            } else if(c == 1){
                num *= i;
            }else if(c == 2){
                num /= i;
            }else if(c == 3){
                if(ans < 0){
                    ans = num;
                }else{
                    ans -= num;
                }
                ans += i;
                num = 0;
                c = -1;
            }
            c++;
        }
        return ans < 0 ? num : ans - num;
    }
}