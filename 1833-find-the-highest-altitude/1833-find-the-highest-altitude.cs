public class Solution {
    public int LargestAltitude(int[] gain) {
        var pref = 0;
        var mx = 0;
        for(var i = 0; i < gain.Length; i++){
            pref += gain[i];
            if(pref > mx){
                mx = pref;
            }
        }

        return mx;
    }
}