/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        if(root is null){
            return [];
        }
        var queue = new Queue<TreeNode>();
        var results = new List<double>{ Math.Round(root.val * 1.0,5) };
        queue.Enqueue(root);

        while(queue.Count > 0){
            var size = queue.Count;
            double sm = 0;
            var cnt = 0;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();

                if(node.left is not null){
                    sm += node.left.val;
                    cnt++;
                    queue.Enqueue(node.left);
                }
                if(node.right is not null){
                    sm += node.right.val;
                    cnt++;
                    queue.Enqueue(node.right);
                }
            }
            if(cnt > 0){
                results.Add(Math.Round(sm / cnt, 5));
            }
        }
        return results;
    }
}