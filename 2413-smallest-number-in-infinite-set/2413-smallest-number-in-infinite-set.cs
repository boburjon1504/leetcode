public class SmallestInfiniteSet {
    private HashSet<int> set;
    private int min = 1;
    public SmallestInfiniteSet() {
        set = new HashSet<int>();
    }
    
    public int PopSmallest() {
        if(set.Contains(min)){
            while(set.Contains(min)){
                min++;
            }
        }
        set.Add(min);
        return min;
    }
    
    public void AddBack(int num) {
        if(set.Contains(num)){
            set.Remove(num);
        }
        if(min > num){
            min = num;
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */