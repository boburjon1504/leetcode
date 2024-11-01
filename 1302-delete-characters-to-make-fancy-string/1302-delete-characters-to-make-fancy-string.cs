public class Solution {
    public string MakeFancyString(string s) {
        var res = new StringBuilder();
        var i = 0;
        var prev = s[0];
        var c = 0;
        while(i < 2 && i < s.Length){
            res.Append(s[i]);
            if(prev == s[i]){
                c++;
            }else{
                prev = s[i];
                c = 1;
            }
            i++;
        }
        for(;i < s.Length; i++){
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