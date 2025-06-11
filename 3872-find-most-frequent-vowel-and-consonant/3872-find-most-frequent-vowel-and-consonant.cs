public class Solution {
    public int MaxFreqSum(string s) {
        var freq = new Dictionary<char, int>();

        int maxV = 0, maxC = 0;

        foreach(var i in s){
            if(!freq.ContainsKey(i)){
                freq[i] = 0;
            }

            freq[i]++;

            if("aeiou".Any(c => c == i)){
                maxV = Math.Max(maxV, freq[i]);
            }else{
                maxC = Math.Max(maxC, freq[i]);
            }
        }

        return maxV + maxC;
    }
}