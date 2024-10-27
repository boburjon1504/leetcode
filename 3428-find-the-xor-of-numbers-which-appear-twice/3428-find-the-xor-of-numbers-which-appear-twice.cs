public class Solution {
    public int DuplicateNumbersXOR(int[] nums) {
        var duplicates = nums.GroupBy(x => x)
            .Select(x => new {
                x.Key,
                Count = x.Count(),
            }).Where(x => x.Count == 2).ToArray();

        if(duplicates.Length == 0) return 0;

        var xor = duplicates[0].Key;
        for(var i = 1; i < duplicates.Length; i++){
            xor ^= duplicates[i].Key;
        }

        return xor;
    }
}