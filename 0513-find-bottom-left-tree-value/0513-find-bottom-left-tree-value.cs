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
    public int FindBottomLeftValue(TreeNode root) {
        return FindLeftMostValue(root);
    }

    private int FindLeftMostValue(TreeNode root){
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var left = root;
        var last = root;
        while(queue.Count > 0){
            var size = queue.Count;
            var leftMost = new Queue<TreeNode>();
            var cnt = 0;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(node.left is not null){
                    queue.Enqueue(node.left);
                    leftMost.Enqueue(node.left);
                }

                if(node.right is not null)
                {
                    queue.Enqueue(node.right);
                    leftMost.Enqueue(node.right);
                    cnt++;
                }
            }
            left = leftMost.Count > 0 ? leftMost.Dequeue() : left;
        }
        return left.val;
    }
}