using System.Text.Json;
public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var dc = new Dictionary<int, int>();
        var count = 0;
        foreach(var n in nums){
            var reminder = k - n;

            if(dc.ContainsKey(reminder) && dc[reminder] > 0){
                count++;
                dc[reminder]--;
            }else{
                if(!dc.ContainsKey(n)){
                    dc[n] = 0;
                }
                dc[n]++;
            }
        }

        return count;
    }
}