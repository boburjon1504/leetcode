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
    public int LongestUnivaluePath(TreeNode root) {
        var max = 0;

        Get(root, 1002, ref max);

        return max;
    }

    private int Get(TreeNode root, int prev, ref int max){
        if(root is null){
            return 0;
        }

        var left = Get(root.left, root.val, ref max);
        var right = Get(root.right, root.val, ref max);
        var total = left + right;

        max = Math.Max(max, total);

        if(root.val == prev){
            total -= Math.Min(left, right);
        }

        Console.WriteLine($"root={root.val}  prev={prev}   [{left}, {right}]");

        return root.val == prev ? total + 1 : 0;
    }
}