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
    public bool EvaluateTree(TreeNode root) {
        if(root.left is null && root.right is null){
            return root.val == 1;
        }

        var left = EvaluateTree(root.left);
        var right = EvaluateTree(root.right);

        if(root.val == 2) return left || right;

        return left && right;
    }
}