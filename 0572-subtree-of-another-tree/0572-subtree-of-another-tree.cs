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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        var r = Get(root);
        var s = Get(subRoot);
        return r.Contains(s);
    }

    private string Get(TreeNode root){
        if(root is null){
            return ",null,";
        }

        return Get(root.left) + Get(root.right) + $",{root.val},";
    }
}