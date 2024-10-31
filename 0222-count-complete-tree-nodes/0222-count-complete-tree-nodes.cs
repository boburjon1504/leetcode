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
    public int CountNodes(TreeNode root) {
        return Count(root);
    }

    private int Count(TreeNode root){
        if(root is null){
            return 0;
        }

        return 1 + Count(root.left) + Count(root.right);
    }
}