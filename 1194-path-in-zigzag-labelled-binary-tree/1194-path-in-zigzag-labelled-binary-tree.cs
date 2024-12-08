public class Solution {
    public IList<int> PathInZigZagTree(int label) {
        var levels =  new List<IList<int>>();
        var c = 1;
        var queue = new Queue<int>();
        queue.Enqueue(c);
        var num = 0;
        var depth = 0;
        var labelIndex = 0;
        while(num < label){
            var size = queue.Count;
            var ls = new List<int>();
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                ls.Add(node);
                if(node == label){
                    num = node;
                }
                queue.Enqueue(node * 2);
                queue.Enqueue(node * 2 + 1);
            }
            if(depth % 2 == 1){
                ls.Reverse();
            }
            if(num == label){
                labelIndex = ls.IndexOf(label);
            }
            depth++;
            levels.Add(ls);
        }
        var ans = new List<int>();
        for(var i = levels.Count - 1; i >= 0; i--){
            ans.Add(levels[i][labelIndex]);
            labelIndex/=2;
        }
        ans.Reverse();
        return ans;
    }
}