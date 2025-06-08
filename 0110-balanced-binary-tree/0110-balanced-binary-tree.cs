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
    public bool IsBalanced(TreeNode root) {
        var min = 0;
        Is(root, ref min);

        return min < 2;
    }

    private int Is(TreeNode root, ref int min){
        if(root is null){
            return 0;
        }

        var left = Is(root.left, ref min);
        var right = Is(root.right, ref min);
        var dif = Math.Abs(right - left);
        min = Math.Max(min, dif);

        return Math.Max(left, right) + 1;
    }
}