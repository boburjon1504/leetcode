public class Solution {
    public int KthFactor(int n, int k) {
        var ls = new List<int>();
        for(var i = 1; i <= n; i++){
            if(n % i > 0) continue;

            ls.Add(i);
        }

        Console.WriteLine(string.Join(" ", ls));

        return k > ls.Count ? -1: ls[k - 1];
    }
}