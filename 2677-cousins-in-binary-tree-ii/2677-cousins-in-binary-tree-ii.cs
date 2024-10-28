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
    public TreeNode ReplaceValueInTree(TreeNode root) {
        var queue = new Queue<TreeNode>();
        long sm = root.val;
        long levelSum = sm;
        queue.Enqueue(root);
        
        while(queue.Count > 0){
            var size = queue.Count;
            sm = 0;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                node.val = (int)levelSum - node.val;
                if(node.right is not null && node.left is not null){
                    var both = node.left.val + node.right.val;
                    (node.left.val, node.right.val) = (both, both);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                    sm += both;
                }else if(node.left is not null){
                    queue.Enqueue(node.left);
                    sm += node.left.val;
                }else if(node.right is not null) {
                    queue.Enqueue(node.right);
                    sm += node.right.val;
                }
            }
            levelSum = sm;
        }

        return root;
    }
}