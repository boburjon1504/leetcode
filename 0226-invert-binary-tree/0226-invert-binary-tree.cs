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
    public TreeNode InvertTree(TreeNode root) {
        var temp = root;
        Invert(temp);

        return root;
    }
    private void Invert(TreeNode root){
        if(root is null){
            return;
        }
            (root.left, root.right) = (root.right, root.left);
        Invert(root.left);
        Invert(root.right);
    }
}