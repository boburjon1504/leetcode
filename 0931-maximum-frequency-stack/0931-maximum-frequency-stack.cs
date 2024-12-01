public class FreqStack {
    private SortedDictionary<int, List<int>> freq;
    private Dictionary<int, int> pairs;
    private Dictionary<int, List<int>> indexes;
    private int index = 0;
    public FreqStack() {
        pairs = new Dictionary<int, int>();
        freq = new SortedDictionary<int, List<int>>();
        indexes = new Dictionary<int, List<int>>();
    }
    
    public void Push(int val) {
        AddToPairs(val);
        RemoveFromFreq(val);
        AddToFreq(val);
        if(!indexes.ContainsKey(val)){
            indexes[val] = new List<int>();
        }
        indexes[val].Add(index);
        index++;
    }

    private void AddToFreq(int key){
        var fr = pairs[key];
        if(!freq.ContainsKey(fr)){
            freq[fr] = new List<int>();
        }

        freq[fr].Add(key);
    }

    private void RemoveFromFreq(int key){
        var fr = pairs[key] - 1;
        if(!freq.ContainsKey(fr)){
            return;
        }
        freq[fr].Remove(key);
        if(freq[fr].Count == 0){
            freq.Remove(fr);
        }
    }

    private void AddToPairs(int key){
        if(!pairs.ContainsKey(key)){
            pairs[key] = 0;
        }

        pairs[key]++;
    }
    
    public int Pop() {
        var lastFreq = freq.Last();
        var last = -1;
        var mx = 0;
        foreach(var x in lastFreq.Value){
            var i = indexes[x][indexes[x].Count - 1];
            if(mx <= i){
                mx = i;
                last = x;
            }
        }
        indexes[last].RemoveAt(indexes[last].Count - 1);
        if(indexes[last].Count == 0){
            indexes.Remove(last);
        }
        lastFreq.Value.Remove(last);
        if(lastFreq.Value.Count == 0){
            freq.Remove(lastFreq.Key);
        }
        pairs[last]--;
        if(pairs[last] == 0){
            pairs.Remove(last);
        }else{
            AddToFreq(last);
        }

        return last;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */