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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if(depth == 1){
            return new TreeNode(val, root);
        }

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var d = 1;
        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(depth - 1 == d){
                    node.left = new TreeNode(val, node.left);
                    node.right = new TreeNode(val, right: node.right);
                }
                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
            d++;
            if(d == depth){
                break;
            }
        }

        return root;
    }
}