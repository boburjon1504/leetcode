public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int f1 = 0, sc1 = 0, f2 = 0, sc2 = 0;
        var c = 0;
        for(var i = 0; i < s1.Length; i++){
            if(s1[i] == s2[i]) continue;

            if(c > 0) return false;

            if(f1 == 0){
                f1 = s1[i];
                sc1 = s2[i];
            }else if(f1 != s2[i] && sc1 != s1[i]){
                return false;
            }else if(f1 == s2[i] && sc1 == s1[i]){
                f2 = s1[i];
                sc2 = s2[i];
                c++;
            }
        }

        return f1 == sc2 && f2 == sc1;
        
    }
}