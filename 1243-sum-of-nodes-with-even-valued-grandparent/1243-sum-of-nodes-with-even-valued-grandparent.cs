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
    public int SumEvenGrandparent(TreeNode root) {
        var sm = 0;

        Sum(root, ref sm);

        return sm;
    }

    private void Sum(TreeNode root, ref int sm){
        if(root is null){
            return;
        }
        if(root.val % 2 == 0 && root.left is not null){
            if(root.left.left is not null){
                sm += root.left.left.val;
            }
            if(root.left.right is not null){
                sm += root.left.right.val;
            }
        }

        if(root.val % 2 == 0  && root.right is not null){
            if(root.right.left is not null){
                sm += root.right.left.val;
            }
            if(root.right.right is not null){
                sm += root.right.right.val;
            }
        }

        Sum(root.left,ref sm);
        Sum(root.right,ref sm);
    }
}