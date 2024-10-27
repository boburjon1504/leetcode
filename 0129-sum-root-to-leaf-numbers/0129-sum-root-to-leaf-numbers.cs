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
    public int SumNumbers(TreeNode root) {
        var sm = 0;
        Numbers(root, 0, ref sm);
        return sm;
    }

    private void Numbers(TreeNode root, int num, ref int sm) {
        if(root is null){
            return;
        }
        num = num * 10 + root.val;
        if(root.left is null && root.right is null){
            sm += num;
        }
        Numbers(root.left, num, ref sm);
        if(root.right is null){
            num /= 10;
        }
        Numbers(root.right, num, ref sm);
    }
}