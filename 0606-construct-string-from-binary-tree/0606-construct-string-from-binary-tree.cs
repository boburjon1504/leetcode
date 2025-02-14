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
    public string Tree2str(TreeNode root) {
        if(root is null){
            return "";
        }

        var left = Tree2str(root.left);
        var right = Tree2str(root.right);

        if(left.Length == 0 && right.Length == 0){
            return $"{root.val}";
        }

        if(left.Length == 0 && right.Length > 0){
            return $"{root.val}()({right})";
        }

        if(right.Length == 0){
            return $"{root.val}({left})";
        }

        return $"{root.val}({left})({right})";
    }
}