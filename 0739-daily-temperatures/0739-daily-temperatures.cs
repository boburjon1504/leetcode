public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<(int val, int i)>();
        var ans = new int[temperatures.Length];

        for(var i = 0; i < temperatures.Length; i++){
            while(stack.Count > 0 && stack.Peek().val < temperatures[i]){
                var pair = stack.Pop();
                ans[pair.i] = i - pair.i;
            }
            stack.Push((temperatures[i], i));
        }

        return ans;
    }
}