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
    public int MinDiffInBST(TreeNode root) {
        var mn = 1_000_000;
        var list = new List<int>();
        GetMin(root, list,ref mn);

        return mn;
    }

    private void GetMin(TreeNode root, IList<int> ls,  ref int mn){
        if(root is null){
            return;
        }

        GetMin(root.left, ls, ref mn);
        if(ls.Count > 0){
            var val = Math.Abs(ls[^1] - root.val);
            if(val < mn){
                mn = val;
            }
        }
        ls.Add(root.val);
        GetMin(root.right, ls, ref mn);
    }
}