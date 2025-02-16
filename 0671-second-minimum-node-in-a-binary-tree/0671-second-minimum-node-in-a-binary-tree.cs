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
    public int FindSecondMinimumValue(TreeNode root) {
        var res = -1;
        Min(root, root.val, ref res);

        return res;
    }

    private void Min(TreeNode root, int min, ref int res){
        if(root is null){
            return;
        }
        if((root.val < res || res < 0) && root.val > min){
            res = root.val;
            
        }
        Min(root.left, min, ref res);
        Min(root.right, min, ref res);
    }
}