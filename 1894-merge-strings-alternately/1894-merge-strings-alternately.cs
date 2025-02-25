public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var mn = Math.Min(word1.Length, word2.Length);
        var sn = new StringBuilder();
        for(var i = 0; i < mn; i++){
            sn.Append($"{word1[i]}{word2[i]}");
        }
        while(mn < word1.Length){
            sn.Append(word1[mn]);
            mn++;
        }

        while(mn < word2.Length){
            sn.Append(word2[mn]);
            mn++;
        }

        return sn.ToString();
    }
}