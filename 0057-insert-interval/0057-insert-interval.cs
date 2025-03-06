public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var inters = intervals.ToList();
        inters.Add(newInterval);
        intervals = inters.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();

        var ans = new List<int[]>{ intervals[0] };

        for(var i = 1; i < intervals.Length; i++){
            var last = ans[ans.Count - 1];
            var inter = intervals[i];

            if(last[1] >= inter[0]){
                last[1] = inter[1] > last[1] ? inter[1] : last[1];
                continue;
            }else if(last[1] < inter[0]){
                ans.Add(inter);
            }
        }

        return ans.ToArray();
    }
    
}