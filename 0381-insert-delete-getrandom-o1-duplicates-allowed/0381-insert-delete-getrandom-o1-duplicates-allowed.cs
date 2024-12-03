public class RandomizedCollection {
    private Dictionary<int, int> pairs;
    private List<int> nums;
    public RandomizedCollection() {
        pairs = new Dictionary<int, int>();
        nums = new List<int>();
    }
    
    public bool Insert(int val) {
        var isPresent = IsPresent(val);
        if(!isPresent){
            pairs[val] = 0;
        }
        pairs[val]++;
        nums.Add(val);
        return !isPresent;
    }
    private bool IsPresent(int val) => pairs.ContainsKey(val);
    public bool Remove(int val) {
        if(!IsPresent(val)){
            return false;
        }
        nums.Remove(val);
        pairs[val]--;

        if(pairs[val] == 0){
            pairs.Remove(val);
        }

        return true;
    }
    
    public int GetRandom() {
        return nums[new Random().Next(0, nums.Count)];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */