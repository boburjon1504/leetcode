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
    public int SumRootToLeaf(TreeNode root) {
        if(root is null){
            return 0;
        }
        var sm = 0;
        GetValues(root, "", ref sm);

        return sm;
        
    }

    private void GetValues(TreeNode root, string binNum, ref int sm) {
        if(root is null){
            return;
        }

        binNum += root.val;
        if(root.right is null && root.left is null){
            var n = ToDecimal(binNum);
            sm += n;
        }
        GetValues(root.left, binNum, ref sm);
        if(root.right is null){
            binNum = binNum.Substring(0, binNum.Length - 1);
        }
        GetValues(root.right, binNum, ref sm);
    }

    private int ToDecimal(string s) {
        var n = 0;
        var power = 0;
        for(var i = s.Length - 1;i >= 0; i--){
            n += int.Parse(s[i].ToString()) * (int)Math.Pow(2, power);
            power++;
        }
        return n;
    }
}