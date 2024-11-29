public class Skiplist {
    private Dictionary<int, int> dict;
    public Skiplist() {
        dict = new Dictionary<int, int>();
    }
    
    public bool Search(int target) {
        return dict.ContainsKey(target) ? dict[target] > 0 : false;
    }
    
    public void Add(int num) {
        if(!dict.ContainsKey(num)){
            dict[num] = 0;
        }
        dict[num]++;
    }
    
    public bool Erase(int num) {
        if(dict.ContainsKey(num) && dict[num] == 0){
            return false;
        }
        if(dict.ContainsKey(num)){
            dict[num]--;
            return true;
        }

        return false;
    }
}

/**
 * Your Skiplist object will be instantiated and called as such:
 * Skiplist obj = new Skiplist();
 * bool param_1 = obj.Search(target);
 * obj.Add(num);
 * bool param_3 = obj.Erase(num);
 */