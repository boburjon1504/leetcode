public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var combs = Combs(n, k, 1, new());
        if(combs is null) return [];

        var set = new HashSet<string>();
        var ans = new List<IList<int>>();
        foreach(var comb in combs){
            var key = string.Join("", comb.Order());
            if(set.Contains(key)) continue;

            set.Add(key);
            ans.Add(comb);
        }

        return ans;
    }

    private IList<IList<int>> Combs(
        int n, int k,int index, 
        Dictionary<string, IList<IList<int>>> memo){
        var key = $"{n},{k},{index}";
        // if(memo.ContainsKey(key)) return memo[key];
        if(k == 0 && n == 0) return [[]];
        if(n <= 0 || k <= 0) return null;

        IList<IList<int>> ans = null;
        for(var i = index; i < 10; i++){
            var combs = Combs(n - i, k - 1, i + 1, memo);
            if(combs is null) continue;

            foreach(var comb in combs){
                if(ans is null){
                    ans = new List<IList<int>>();
                }
                if(comb.Sum() < n){
                    comb.Add(i);
                }

                ans.Add(comb);
            }
        }

        memo[key] = ans;

        return ans;
    }
}