using System.Text.Json;

public class Solution {
    public string FindCommonResponse(IList<IList<string>> responses) {
        var dc = new Dictionary<string, int>();
        foreach(var response in responses){
            var set = new HashSet<string>();
            foreach(var res in response){
                set.Add(res);
            }

            foreach(var i in set){
                if(!dc.ContainsKey(i)){
                    dc[i] = 0;
                }
                dc[i]++;
            }
        }
        var mx = 0;
        var mxString = "";

        foreach(var (key, val) in dc){
            if (val > mx){
                mx = val;
                mxString = key;
            }else if (val == mx && key.CompareTo(mxString) < 0){
                mxString = key;
            }
        }

        return mxString;
    }
}