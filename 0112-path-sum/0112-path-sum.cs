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
    public bool HasPathSum(TreeNode root, int targetSum) {
        var res = false;
        HasPathSum(root, targetSum, 0, ref res);

        return res;
    }

    private void HasPathSum(TreeNode root, int target,int sm, ref bool res){
        if(root is null){
            return;
        }

        sm += root.val;
        if(root.left is null && root.right is null && sm == target){
            res = true;
            return;
        }

        HasPathSum(root.left, target,sm,ref res);
        if(root.right is null){
            sm -= root.val;
        }
        HasPathSum(root.right, target, sm, ref res);
    }
}