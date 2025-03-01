using System.Text.Json;
public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        return GetSentences(s, wordDict);
    }

    private IList<string> GetSentences(string s, IList<string> wordDict){
        if(s.Length == 0) return [""];
        var ls = new List<string>();

        foreach(var word in wordDict) {
            var index = s.IndexOf(word);
            if(index < 0 || index > 0) continue;
            var sentences = GetSentences(s.Substring(index + word.Length), wordDict);
            if(sentences.Count > 0){
                for(var i = 0; i < sentences.Count; i++){
                    sentences[i] = sentences[i].Length > 0 ? 
                                                            $"{word} {sentences[i]}" : 
                                                            word;
                }
                ls.AddRange(sentences);
            }
        }

        return ls;
    }

}