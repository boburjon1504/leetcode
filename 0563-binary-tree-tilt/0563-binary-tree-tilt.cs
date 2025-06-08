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
    public int FindTilt(TreeNode root) {
        var sm = 0;

        FindTilt(root, ref sm);

        return sm;
    }

    private int FindTilt(TreeNode root, ref int sm){
        if(root is null){
            return 0;
        }

        var left = FindTilt(root.left, ref sm);
        var right = FindTilt(root.right, ref sm);

        var total = left + right + root.val;

        sm += Math.Abs(left - right);

        return total;
    }
}