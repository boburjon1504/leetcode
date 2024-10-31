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
    public int MaxLevelSum(TreeNode root) {
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var level = 1;
        var depth = 0;
        var mx = root.val;
        while(queue.Count > 0){
            var size = queue.Count;
            var sm = 0;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                sm += node.val;

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
            depth++;
            if(mx < sm){
                mx = sm;
                level = depth;
            }
        }

        return level;
    }
}