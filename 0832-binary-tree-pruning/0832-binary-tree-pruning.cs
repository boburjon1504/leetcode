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
    public TreeNode PruneTree(TreeNode root) {
        var one = HasOne(root);
        if(!one){
            return null;
        }
        InOrder(root, null);

        return root;
    }

    private void InOrder(TreeNode root, TreeNode parent){
        if(root is null){
            return;
        }
        var one = HasOne(root);
        if(!one){
            if(parent.left == root){
                parent.left = null;
            }else{
                parent.right = null;
            }
        }
        InOrder(root.left, root);
        InOrder(root.right, root);
    }

    private bool HasOne(TreeNode root){
        if(root is null){
            return false;
        }
        if(root.val == 1){
            return true;
        }

        return false || HasOne(root.left) || HasOne(root.right);
    }
}