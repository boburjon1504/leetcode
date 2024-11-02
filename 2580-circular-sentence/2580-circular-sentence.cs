public class Solution {
    public bool IsCircularSentence(string sentence) {
        var words = sentence.Split().ToList();
        if(words[0][0] != words[^1][^1]){
            return false;
        }

        for(var i = 1; i < words.Count; i++){
            if(words[i][0] != words[i-1][^1]){
                return false;
            }
        }

        return true;
    }
}