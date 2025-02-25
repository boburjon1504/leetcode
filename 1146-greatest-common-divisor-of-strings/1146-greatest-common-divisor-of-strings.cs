public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        var str = new StringBuilder();
        var ans = "";
        foreach(var i in str1){
            str.Append(i);
            var length = str.Length;
            int l1 = str1.Length, l2 = str2.Length;

            if(l1 % length == 0 && l2 % length == 0){
                var s1 = string.Join("",Enumerable
                                .Range(0, l1 / length)
                                .Select(_ => str));
                
                if(s1 != str1){
                    continue;
                }
                var s2 = string.Join("",Enumerable
                                .Range(0, l2 / length)
                                .Select(_ => str));

                if(s2 != str2){
                    continue;
                }
                ans = str.ToString();
            }
        }

        return ans;
    }
}