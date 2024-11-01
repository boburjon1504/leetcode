public class Solution {
    public string MakeFancyString(string s) {
        var res = new StringBuilder();
        var prev = s[0];
        var c = 0;
        for(var i = 0;i < s.Length; i++){
            if(prev == s[i] && c == 2){
                continue;
            }

            if(prev != s[i]){
                prev = s[i];
                c = 1;
            }else
            if(prev == s[i]){
                c++;
            }
            res.Append(s[i]);
        }
        return res.ToString();
    }
}