public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        var c = 0;
        for(var i = 0;i < str1.Length; i++){
            if(str1[i] == str2[c] || (str1[i] + 1 == str2[c]) || (str1[i] == 'z' && str2[c] == 'a')){
                c++;
            }
            if(c == str2.Length){
                return true;
            }
        }
        return false;
    }
}