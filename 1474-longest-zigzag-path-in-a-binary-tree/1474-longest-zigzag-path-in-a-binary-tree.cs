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
    public int LongestZigZag(TreeNode root) {
        var mx = 0;

        MaxZigZag(root, false, 0, ref mx);

        return mx;
    }

    private void MaxZigZag(TreeNode root, bool isRight, int c,ref int mx){
        if(root is null){
            return;
        }

        if(isRight && root.left is null && c > mx){
            mx = c;
        }
        if(!isRight && root.right is null && c > mx){
            mx = c;
        }

        MaxZigZag(root.left, false, (isRight ? c + 1 : 1), ref mx);
        MaxZigZag(root.right, true, (isRight ? 1 : c + 1), ref mx);
    }
}