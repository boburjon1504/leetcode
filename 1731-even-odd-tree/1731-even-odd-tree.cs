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
    public bool IsEvenOddTree(TreeNode root) {
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var depth = 0;
        while(queue.Count > 0){
            var prev = 0;
            var size = queue.Count;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(i > 0 && depth % 2 == 0 && node.val % 2 == 1 && node.val <= prev){
                    return false;
                }

                if(i > 0 && depth % 2 == 1 && node.val % 2 == 0 && node.val >= prev){
                    return false;
                }
                if((depth % 2 == 0 && node.val % 2 == 0) || 
                    (depth % 2 == 1 && node.val % 2 == 1)){
                    return false;
                }
                prev = node.val;
                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
            depth++;
        }
        return true;
    }
}