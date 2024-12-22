public class Solution {
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        var dc = new Dictionary<int, HashSet<int>>();

        foreach(var log in logs){
            if(!dc.ContainsKey(log[0])){
                dc[log[0]] = new HashSet<int>();
            }

            dc[log[0]].Add(log[1]);
        }

        var ans = new int[k];
        foreach(var (key, value) in dc){
            var count = value.Count;
            ans[count - 1]++;
        }

        return ans;
    }
}