public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var pref = new double[nums.Length];
        pref[0] = nums[0];
        for(var i = 1; i < nums.Length; i++){
            pref[i] = pref[i - 1] + nums[i];
        }
        double mx = int.MinValue;
        k--;
        for(var i = 0; i < pref.Length; i++){
            if(i + k >= pref.Length) break;

            var val = (pref[i + k] - (i == 0 ? 0 : pref[i - 1])) / (k + 1);

            if(val > mx){
                mx = val;
            }
        }

        return Math.Round(mx,5);
    }
}