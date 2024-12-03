public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        var builder = new StringBuilder();
        var count = 0;
        for(int i=0;i<s.Length;i++){
            if(count<spaces.Length && i==spaces[count]){
                builder.Append(" ");
                count++;
            }
            builder.Append(s[i]);
        }
        return builder.ToString();   
    }
}