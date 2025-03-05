public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        

        var combs = Comb(target,candidates, new());

        var set = new HashSet<string>();
        var ans = new List<IList<int>>();
        
        foreach(var comb in combs){
            var str = GetAsSortedString(comb);

            if(set.Contains(str)){
                continue;
            }

            set.Add(str);

            ans.Add(comb);
        }

        return ans;
    }

    private string GetAsSortedString(IList<int> nums){
        return string.Join("", nums.Order());
    }
    private IList<IList<int>> Comb(
        int target, int[] candidates, 
        Dictionary<int, IList<IList<int>>> memo){

        if(memo.ContainsKey(target)) return memo[target];

        if(target == 0) return [[]];
        if(target < 0) return null;
        var ls = new List<IList<int>>();
        foreach(var n in candidates){
            var res = Comb(target - n, candidates, memo);

            if(res is null) continue;

            for(var i = 0; i < res.Count; i++){
                res[i].Add(n);
                ls.Add(res[i]);
            }
        }

        return ls;
    }
}