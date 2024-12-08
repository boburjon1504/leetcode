public class Solution {
    public int MinSteps(int n) {
        var num = 1;
        var prev = 0;
        var c = 0;
        while(num < n){
            if(n % num == 0){
                if(prev != num){
                    prev = num;
                    c++;
                }
                num *= 2;

                c++;
            }else{
                num += prev;
                c++;
            }
        }

        return c;
    }
}