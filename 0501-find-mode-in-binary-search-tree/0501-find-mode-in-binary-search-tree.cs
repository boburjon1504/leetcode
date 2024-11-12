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
    public int[] FindMode(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var mx = 0;
        var dc = new Dictionary<int,int>();
        while(queue.Count > 0){
            var size = queue.Count;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(!dc.ContainsKey(node.val)){
                    dc[node.val] = 0;
                }
                dc[node.val]++;
                if(dc[node.val] > mx){
                    mx = dc[node.val];
                }
                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
        }

        return dc.Where(x => x.Value == mx).Select(x => x.Key).ToArray();
    }
}