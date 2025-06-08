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
    public int DiameterOfBinaryTree(TreeNode root) {
        var max = 0;
        Get(root, ref max);

        return max;
    }

    private int Get(TreeNode root, ref int max){
        if(root is null){
            return 0;
        }

        var left = Get(root.left, ref max);
        var right = Get(root.right, ref max);
        
        max = Math.Max(max, left + right);

        return Math.Max(left, right) + 1;
    }
}