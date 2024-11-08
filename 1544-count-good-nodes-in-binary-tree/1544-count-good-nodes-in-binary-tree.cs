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
    public int GoodNodes(TreeNode root) {
        var cnt = 0;
        Count(root, root.val, ref cnt);

        return cnt;
    }

    private void Count(TreeNode root, int mx, ref int cnt){
        if(root is null){
            return;
        }
        if(root.val >= mx){
            cnt++;
            mx = root.val;
        }
        Count(root.left, mx, ref cnt);
        Count(root.right, mx, ref cnt);
    }
}