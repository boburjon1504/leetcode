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
    public int MaxAncestorDiff(TreeNode root) {
        var res = 0;
        FindMaxDiff(root, root.val, root.val,ref res);
        
        return res;
    }

    private void FindMaxDiff(TreeNode root,int min, int max,ref int res){
        if(root is null) return;

        min = min > root.val ? root.val : min;
        max = max < root.val ? root.val : max;

        var dif = Math.Abs(max - min);
        res = res < dif ? dif : res;

        FindMaxDiff(root.left, min, max, ref res);
        FindMaxDiff(root.right, min, max, ref res);
    }
}