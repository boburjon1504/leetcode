public class LFUCache {
    private Dictionary<int, int[]> pairs;
    private SortedDictionary<int, List<int>> freq;
    private int cap;
    public LFUCache(int capacity) {
        pairs = new Dictionary<int, int[]>();
        freq = new SortedDictionary<int, List<int>>();
        cap = capacity;
    }
    
    public int Get(int key) {
        if(!pairs.ContainsKey(key)){
            return - 1;
        }
        RemoveFromFreq(key);
        Increment(key);
        AddToFreq(key);

        return pairs[key][0];
    }
    private void AddToFreq(int key){
        var fr = pairs[key][1];
        if(!freq.ContainsKey(fr)){
            freq[fr] = new List<int>();
        }

        freq[fr].Add(key);
    }
    private void RemoveFromFreq(int key){
        var fr = pairs[key][1];
        freq[fr].Remove(key);

        if(freq[fr].Count == 0){
            freq.Remove(fr);
        }
    }
    private void Increment(int key){
        pairs[key][1]++;
    }
    
    public void Put(int key, int value) {
        if(!pairs.ContainsKey(key) && cap == pairs.Count){
            var lessFreq = freq.First();
            var first = lessFreq.Value[0];
            lessFreq.Value.Remove(first);
            pairs.Remove(first);
        }
        if(!pairs.ContainsKey(key)){
            pairs[key] = new int[2]{ value, 0 };
        }else{
            pairs[key][0] = value;
            RemoveFromFreq(key);
        }
        Increment(key);
        AddToFreq(key);
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */