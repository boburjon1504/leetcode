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
    public bool IsUnivalTree(TreeNode root) {
        return IsUnivalTree(root, root.val);
    }
    private bool IsUnivalTree(TreeNode root, int prev){
        if(root is null){
            return true;
        }
        if(prev != root.val){
            return false;
        }

        return true && IsUnivalTree(root.left, root.val) && IsUnivalTree(root.right, root.val);
    }
}