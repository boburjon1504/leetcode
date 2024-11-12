public class Solution {
    public int[] FindArray(int[] pref) {
        var prev = pref[0];
        for(var i = 1; i < pref.Length; i++){
            var a = pref[i];
            pref[i] ^= prev;
            prev = a;
        }
        return pref;
    }
}