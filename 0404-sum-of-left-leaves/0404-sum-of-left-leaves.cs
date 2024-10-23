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
    public int SumOfLeftLeaves(TreeNode root) {
        var sm = 0;
        GetLeftLeaf(root,ref sm);

        return sm;
    }

    private void GetLeftLeaf(TreeNode root, ref int sm){
        if(root is null){
            return;
        }
        sm = sm;
        if(root.left is not null && root.left.left is null && root.left.right is null){
            sm += root.left.val;
        }


        GetLeftLeaf(root.left,ref sm);
        GetLeftLeaf(root.right,ref sm);

    }
}