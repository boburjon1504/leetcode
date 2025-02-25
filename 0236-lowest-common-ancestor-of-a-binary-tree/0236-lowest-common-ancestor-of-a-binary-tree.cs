/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode res = null;

        Find(root, p, q, ref res);

        return res;
    }

    private int Find(TreeNode root, TreeNode p, TreeNode q, ref TreeNode res){
        if(root is null){
            return 0;
        }

        var left = Find(root.left, p, q, ref res);
        var right = Find(root.right, p, q, ref res);

        if(left == 1 && right == 1){
            res = root;
            return left + right;
        }
        Console.WriteLine($"{root.val}  {left}  {right}");
        if((root.val == p.val || root.val == q.val) && (left == 1 || right == 1)){
            res = root;

            return left + right;
        }

        if(root.val == p.val || root.val == q.val){
            return 1;
        }

        return left + right;
    }
}