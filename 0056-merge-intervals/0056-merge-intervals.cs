public class Solution {
    public int[][] Merge(int[][] intervals) {

    intervals = intervals.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();

    var ans = new List<IList<int>>{ intervals[0] };

    for(var i = 1; i < intervals.Length; i++){
        var last = ans[^1];
        var inter = intervals[i];

        if(last[1] >= inter[0]){
            last[1] = inter[1] > last[1] ? inter[1] : last[1];
            continue;
        }else if(last[1] < inter[0]){
            ans.Add(inter);
        }
    }

     return ans.Select(x => x.ToArray()).ToArray();   
    }
}