public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        var dc = new Dictionary<int, int>();
        var mx = 0;

        foreach(var n in arr1){
            var a = n;
            while(a > 0){
                dc[a] = a.ToString().Length;
                a /= 10;
            }
        }

        foreach(var n in arr2){
            var a = n;
            while(a > 0){
                if(dc.ContainsKey(a) && dc[a] > mx){
                    mx = dc[a];
                }
                a /= 10;
            }
        }

        return mx;
    }
}