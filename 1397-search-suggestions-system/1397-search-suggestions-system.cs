public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products);
        var prefix = new StringBuilder();
        var ans = new List<IList<string>>();
        foreach(var @char in searchWord){
            prefix.Append(@char);

            var index = BS(products, prefix.ToString());
            var ls = new List<string>();
            var length = prefix.Length < products[index].Length ? prefix.Length : products[index].Length;
            if(products[index].Substring(0, length).CompareTo(prefix.ToString())!= 0){
                index++;
            }
            for(; index < products.Length && ls.Count < 3; index++){
                length = prefix.Length < products[index].Length ? prefix.Length : products[index].Length;
                if(prefix.ToString().CompareTo(products[index].Substring(0,length))!=0){
                    break;
                }
                ls.Add(products[index]);
            }
            ans.Add(ls);
        }

        return ans;
    }

    private int BS(string[] products, string prefix){
        int l = 0, r = products.Length - 1;

        while(l < r){
            var md = (l + r) / 2;
            var length = prefix.Length < products[md].Length ? prefix.Length : products[md].Length;
            var comparisonResult = products[md]
            .Substring(0, length).CompareTo(prefix);
            if(comparisonResult == 0){
                r = md - 1;
            }else if(comparisonResult < 1){
                l = md + 1;
            }else{
                r = md - 1;
            }
        }
        return l;
    }
}