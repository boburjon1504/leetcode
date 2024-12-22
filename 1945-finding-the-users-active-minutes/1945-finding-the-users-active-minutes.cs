public class Solution {
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        var dc = new Dictionary<int, HashSet<int>>();

        foreach(var log in logs){
            if(!dc.ContainsKey(log[0])){
                dc[log[0]] = new HashSet<int>();
            }

            dc[log[0]].Add(log[1]);
        }
        var freq = new Dictionary<int, int>();

        foreach(var (key, value) in dc){
            var count = value.Count;
            if(!freq.ContainsKey(count)){
                freq[count] = 0;
            }

            freq[count]++;
        }

        var ans = new int[k];

        for(var i = 0; i < k; i++){
            if(freq.ContainsKey(i + 1)){
                ans[i] = freq[i + 1];
            }
        }

        return ans;
    }
}