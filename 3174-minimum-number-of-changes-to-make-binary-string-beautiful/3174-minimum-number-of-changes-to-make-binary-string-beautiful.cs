public class Solution {
    public int MinChanges(string s) {
        var c = new StringBuilder();
        var dc = new List<int>();
        foreach(var i in s){
            if(c.Length == 0){
                c.Append(i);
            }else
            if(c[c.Length - 1] != i){
                dc.Add(c.Length);
                c = new StringBuilder();
                c.Append(i);
            }else{
                c.Append(i);
            }
        }
        dc.Add(c.Length );
        var cnt = 0;

        for(var i = 0; i < dc.Count - 1; i++){
            if(dc[i] % 2 == 0){
                continue;
            }else{
                cnt++;
                dc[i + 1]++;
            }
        }
        return cnt;
    }
}