public class Solution {
    private int l;
    
    private List<(int l, int r)> ranges;
    public Solution(int n, int[] blacklist) {
        Array.Sort(blacklist);
        ranges = new List<(int l, int r)>();
        var prev = 0;
        for(var i = 0; i < blacklist.Length; i++){
            if(prev != blacklist[i]){
                ranges.Add((prev, blacklist[i]));
            }
            prev = blacklist[i] + 1;
        }
        if(prev != n){
            ranges.Add((prev, n));
        }

    }
    
    public int Pick() {
        var random = new Random();
        var randomRange = ranges[random.Next(ranges.Count)];

        return random.Next(randomRange.l, randomRange.r);
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(n, blacklist);
 * int param_1 = obj.Pick();
 */