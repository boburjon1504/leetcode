public class Solution {
    public int MaxVowels(string s, int k) {
        var prefCounts = new int[s.Length];
        prefCounts[0] = "aeiou".Contains(s[0]) ? 1 : 0;

        for(var i = 1; i < s.Length; i++){
            prefCounts[i] = ("aeiou".Contains(s[i]) ? 1 : 0) + prefCounts[i - 1];
        }
        int mx = 0;

        for(var i = 0; i < s.Length; i++){
            if(i + k - 1 >= s.Length) break;

            int cnt = prefCounts[i + k - 1] - (i > 0 ? prefCounts[i - 1] : 0);

            if(cnt > mx){
                mx = cnt;
            }
        }

        return mx;
    
    }
}