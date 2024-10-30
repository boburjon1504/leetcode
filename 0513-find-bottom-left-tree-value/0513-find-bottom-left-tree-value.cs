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
        var left = root;

        queue.Enqueue(root);
        while(queue.Count > 0){
            var size = queue.Count;
            var leftMost = new Queue<TreeNode>();
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
                }
            }
            left = leftMost.Count > 0 ? leftMost.Dequeue() : left;
        }
        return left.val;
    }
}