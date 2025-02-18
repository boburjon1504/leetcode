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
    public IList<IList<int>> ClosestNodes(TreeNode root, IList<int> queries) {
        var ans = new List<IList<int>>();

        var ls = new List<int>();
        InOrder(root, ls);
        foreach(var i in queries){
            var j = Search(ls, i);
            int a = 0, b = 0;
            if(ls[j] <= i){
                a = ls[j];
            }else if(j == 0){
                a = -1;
            }else{
                a = ls[j - 1];
            }

            if(ls[j] >= i){
                b = ls[j];
            }else if(j == ls.Count - 1){
                b = -1;
            }else{
                b = ls[j + 1];
            }
            ans.Add([a, b]);
        }
        return ans;
    }
    private void InOrder(TreeNode root, IList<int> ls){
        if(root is null) return;

        InOrder(root.left, ls);
        ls.Add(root.val);
        InOrder(root.right, ls);
    }
    private int Search(IList<int> ls, int val){
        int l = 0, r = ls.Count - 1;

        while(l < r){
            var md = (l + r) / 2;

            if(ls[md] < val){
                l = md + 1;
            }else if(ls[md] == val){
                return md;
            }else{
                r = md - 1;
            }
        }
                
        return l;
    }
}