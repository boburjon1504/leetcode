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
    public int AverageOfSubtree(TreeNode root) {
        var cnt = 0;
        
        Order(root, ref cnt);

        return cnt;
    }

    private void Order(TreeNode root, ref int cnt){
        if(root is null){
            return;
        }
        int c = 0, sm = 0;
        Sum(root, ref c, ref sm);
        if(c > 0 && sm / c == root.val){
            cnt++;
        }

        Order(root.left, ref cnt);
        Order(root.right, ref cnt);
    }

    private void Sum(TreeNode root, ref int c, ref int sm){
        if(root is null){
            return;
        }
        c++;
        sm += root.val;
        Sum(root.left, ref c, ref sm);
        Sum(root.right, ref c, ref sm);
    }
}