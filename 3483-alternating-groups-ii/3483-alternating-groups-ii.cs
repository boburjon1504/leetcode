public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        var ls = new List<int>();
        ls.AddRange(colors);

        for(var i = 0; i < k - 1; i++){
            ls.Add(colors[i]);
        }
        

        int l = 0, r = 0, cnt = 0;

        while(r < ls.Count){
            if(r > 0 && ls[r] == ls[r - 1]){
                l = r;
            }
            var len = r - l + 1;
            if(len == k){
                l++;
                cnt++;
            }
            r++;
        }

        return cnt;
    }
}