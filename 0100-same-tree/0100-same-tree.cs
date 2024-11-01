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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p is not null && q is not null && p.val != q.val){
            return false;
        }
        return IsSame(p, q);
    }

    private bool IsSame(TreeNode p, TreeNode q){
        if(p is null && q is null){
            return true;
        }
        if(p is null || q is null ||
        (p.left is null && q.left is not null) ||
        (p.left is not null && q.left is null) ||
        (p.right is null && q.right is not null) ||
        (p.right is not null && q.right is null) ||
        (p.right is not null && q.right is not null && (p.right.val != q.right.val)) || 
        (p.left is not null && q.left is not null && (p.left.val != q.left.val))){
            return false;
        }

        return true && IsSame(p.left, q.left) && IsSame(p.right, q.right);
    }
}