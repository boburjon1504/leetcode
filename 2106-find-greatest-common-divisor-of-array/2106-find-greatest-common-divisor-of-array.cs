public class Solution {
    public int FindGCD(int[] nums) {

        int mn = int.MaxValue, mx = 1; 
        for(var i = 0; i < nums.Length; i++){
            if(mn > nums[i]){
                mn = nums[i];
            }

            if(mx < nums[i]){
                mx = nums[i];
            }
        }    
        return Gcd(mx, mn);
    }
    
    private int Gcd(int a, int b){
        if(b == 0){
            return a;
        }

        return Gcd(b, a % b);
    }
}