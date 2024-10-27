/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        TreeNode res = null;
        GetTarget(original, cloned, target, ref res);

        return res;
    }

    private void GetTarget(TreeNode original, TreeNode cloned, TreeNode target, ref TreeNode res){
        if(original is null){
            return;
        }

        if(original == target){
            res = cloned;
        }

        GetTarget(original.left,cloned.left, target, ref res);
        
        GetTarget(original.right,cloned.right, target, ref res);
    }
}