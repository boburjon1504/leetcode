public class Solution {
    public int NumDecodings(string s) {
        var ans = Enumerable
                        .Range(1, 'Z' - 'A' + 1)
                        .Select(x => x.ToString())
                        .ToArray();


        return Count(s, ans, new());
    }

    private int Count(string s, string[] arr, Dictionary<string, int> memo){
        if(memo.ContainsKey(s)) return memo[s];
        if(s.Length == 0) return 1;

        var totalCount = 0;
        foreach(var n in arr){
            if(s.StartsWith(n)){
                totalCount += Count(s.Substring(n.Length), arr, memo);
            }
        }

        memo[s] = totalCount;

        return totalCount;
    }
}