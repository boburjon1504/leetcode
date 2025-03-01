public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        return CanBreak(s, wordDict, new());
    }

    private bool CanBreak(string s, IList<string> wordDict, Dictionary<string, bool> memo){
        if(memo.ContainsKey(s)) return memo[s];
        if(s.Length == 0) return true;

        foreach(var word in wordDict){
            var index = s.IndexOf(word);
            if(index != 0) continue;

            if(CanBreak(s.Substring(index + word.Length), wordDict, memo)){
                memo[s] = true;
                return true;
            }
        }
        memo[s] = false;
        return false;
    }
}