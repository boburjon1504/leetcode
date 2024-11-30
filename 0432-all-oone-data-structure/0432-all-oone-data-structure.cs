using System.Text.Json;
public class AllOne {
    private Dictionary<string, int> pairs;
    private SortedDictionary<int, List<string>> freq;
    // private int mx = 0;
    // private int mn = 1_000_000;
    public AllOne() {
        pairs = new Dictionary<string, int>();
        freq = new SortedDictionary<int, List<string>>();
    }
    
    public void Inc(string key) {
        if(!pairs.ContainsKey(key)){
            pairs[key] = 0;
        }else{
            freq[pairs[key]].Remove(key);
            if(freq[pairs[key]].Count == 0){
                freq.Remove(pairs[key]);
            }
        }
        pairs[key]++;
        if(!freq.ContainsKey(pairs[key])){
            freq[pairs[key]] = new List<string>();
        }
        freq[pairs[key]].Add(key);
        
        // if(mx < pairs[key]){
        //     mx = pairs[key];
        // }
        // if(mn > pairs[key]){
        //     mx = pairs[key];
        // }
    }
    
    public void Dec(string key) {
        var fr = pairs[key];
        pairs[key]--;
        if(pairs[key] == 0){
            pairs.Remove(key);
        }
        freq[fr].Remove(key);
        if(freq[fr].Count == 0){
            freq.Remove(fr);
        }
        fr--;
        if(fr > 0){
            if(!freq.ContainsKey(fr)){
                freq[fr] = new List<string>();
            }
            freq[fr].Add(key);
        }

        // if(fr == mx && freq.Count > 0){
        //     mx = freq.Last().Key;
        // }
        // if(fr == mn && freq.Count > 0){
        //     mn = freq.Last().Key;
        // }
    }
    
    public string GetMaxKey() => freq.Count > 0 ? freq.Last().Value.First() : "";
    
    public string GetMinKey() => freq.Count > 0 ? freq.First().Value.First() : "";
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */