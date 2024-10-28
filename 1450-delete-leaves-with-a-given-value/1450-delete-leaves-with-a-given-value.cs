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
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        var i = 0;
        while(i < 2000){
            Remove(root, null,target);
            if(root.left is null && root.right is null && root.val == target){
                return null;
            }
            i++;
        }

        return root;
    }

    private void Remove(TreeNode root, TreeNode prev, int target){
        if(root is null){
            return;
        }
        if(root.left is null && root.right is null && root.val == target){
            if(prev.left == root){
                prev.left = null;
            }else{
                prev.right = null;
            }
            return;
        }

        Remove(root.left, root, target);
        Remove(root.right, root, target);
    }
}