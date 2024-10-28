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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        TreeNode root = null;
        foreach(var n in nums){
            if(root is null){
                root = new TreeNode(n);
            }else if(root.val < n){
                root = new TreeNode(n, root);
            }else{
                TreeNode temp = root, prev = null;
                while(temp is not null && temp.val > n){
                    prev = temp;
                    temp = temp.right;
                }
                prev.right = new TreeNode(n, temp);

            }
        }
        return root;
    }
}