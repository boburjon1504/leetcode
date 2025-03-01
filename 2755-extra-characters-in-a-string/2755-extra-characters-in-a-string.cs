public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        return Min(s, dictionary, new());
    }

    private int Min(string s, string[] dictionary, Dictionary<string, int> memo) {
        if(memo.ContainsKey(s)) return memo[s];
        if(s.Length == 0) return 0;

        var mn = s.Length;
        foreach(var word in dictionary){
            var index = s.IndexOf(word);

            if(index < 0) continue;
            var extra = index + Min(s.Substring(index + word.Length), dictionary, memo);

            if(extra < mn){
                mn = extra;
            }
        }
        memo[s] = mn;
        return mn;
    }
}