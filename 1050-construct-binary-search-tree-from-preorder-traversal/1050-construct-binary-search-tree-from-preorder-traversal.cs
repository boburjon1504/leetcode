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
    public TreeNode BstFromPreorder(int[] preorder) {
        var root = new TreeNode(preorder[0]);

        for(var i = 1; i < preorder.Length; i++){
            Insert(root, preorder[i]);
        }

        return root;
    }

    private TreeNode Insert(TreeNode root, int val){
        if(root is null){
            return new TreeNode(val);
        }

        if(root.val > val){
            root.left = Insert(root.left, val);
        }else{
            root.right = Insert(root.right, val);
        }

        return root;
    }
}