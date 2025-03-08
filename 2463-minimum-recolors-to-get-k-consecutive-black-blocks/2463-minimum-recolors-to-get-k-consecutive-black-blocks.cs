public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        var pref = new int[blocks.Length];
        pref[0] = blocks[0] == 'W' ? 1 : 0;

        for(var i = 1; i < blocks.Length; i++){
            pref[i] = pref[i - 1] + (blocks[i] == 'W' ? 1 : 0);
        }
        var mn = int.MaxValue;

        for(var i = 0; i < pref.Length; i++){
            if(i + k > pref.Length){
                break;
            }
            var val = pref[k + i - 1];
            if(i > 0){
                val -= pref[i - 1];
            }
            if(val < mn){
                mn = val;
            }
        }

        return mn;
    }
}