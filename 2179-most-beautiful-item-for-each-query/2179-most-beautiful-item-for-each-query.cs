public class Solution {
    public int[] MaximumBeauty(int[][] items, int[] queries) {
        items = items
                    .OrderBy(x => x[0])
                    .ThenBy(x => x[1])
                    .ToArray();
        var mx = 0;

        for(var i = 0; i < items.Length; i++){
            if(mx < items[i][1]){
                mx = items[i][1];
            }else{
                items[i][1] = mx;
            }
        }
        var ans = new int[queries.Length];  
        for(var i = 0; i < queries.Length; i++){
            int l = 0, r = items.Length - 1;

            while(l <= r){
                var md = (l + r) / 2;
                if(items[md][0] == queries[i]){
                    l = md + 1;
                }else if(items[md][0] > queries[i]){
                    r = md - 1;
                }else {
                    l = md + 1;
                }
            }
            if(l >= items.Length){
                ans[i] = items[^1][1];
            }else if(l == 0){
                ans[i] = 0;
            }else {
                ans[i] = items[l - 1][1];
            }
        }      

        return ans;
    }
}