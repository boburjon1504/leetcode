public class Solution {
    public bool CheckIfCanBreak(string s1, string s2) {
        var order1 = s1.Order().ToArray();
        var order2 = s2.Order().ToArray();
        int c1 = 0, c2 = 0;
        for(var i = 0; i < order1.Length; i++){
            if(order2[i] <= order1[i]){
                c1++;
            }

            if(order2[i] >= order1[i]){
                c2++;
            }
        }

        return c2 == s1.Length || c1 == s1.Length;
    }
}