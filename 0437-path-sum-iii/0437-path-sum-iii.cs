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
    public int PathSum(TreeNode root, int targetSum) {
        var cnt = 0;

        InOrder(root, targetSum,ref cnt);

        return cnt;
    }

    public void InOrder(TreeNode root, int target,ref int cnt){
        if(root is null){
            return;
        }
        Count(root, target,0, ref cnt);

        InOrder(root.left, target,ref cnt);
        InOrder(root.right, target,ref cnt);
    }

    private void Count(TreeNode root, long target, long sm,ref int cnt){
        if(root is null) return;

        sm += root.val;
        if(sm == target){
            cnt++;
        }
        Count(root.left, target, sm, ref cnt);
        if(root.right is null){
            sm -= root.val;
        }
        Count(root.right, target, sm, ref cnt);
    }
}