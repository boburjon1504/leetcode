/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */

public class Solution {
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z) {
        var ans = new List<IList<int>>();
        for(var i = 1; i <= 1000; i++){
            for(var j = 1; j <= 1000; j++){
                if(customfunction.f(i, j) == z){
                    ans.Add([i,j]);
                }
            }
        }

        return ans;
    }
}