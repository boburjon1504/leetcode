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
    public int PseudoPalindromicPaths (TreeNode root) {
        var cnt = 0;
        Iterate(root, new int[10], 0,ref cnt);

        return cnt;
    }

    private void Iterate(TreeNode root, int[] nodes,int freq,ref int cnt){
        if(root is null) return;

        nodes[root.val]++;
        if(nodes[root.val] % 2 == 1){
            freq++;
        }else{
            freq--;
        }
        
        if(root.left is null && root.right is null){
            cnt = freq <= 1 ? cnt + 1 : cnt;
        }
        Iterate(root.left, nodes, freq, ref cnt);


        Iterate(root.right, nodes, freq, ref cnt);
        nodes[root.val]--;
        if(nodes[root.val] % 2 == 1){
            freq++;
        }else{
            freq--;
        }
    }

    private bool IsPseudo(StringBuilder str){
        var freq = new int[70];
        var c = 0;
        for(var i = 0; i < str.Length; i++){
            freq[str[i]]++;

            if(freq[str[i]] % 2 == 1){
                c++;
            }else{
                c--;
            }
        }

        return c <= 1;
    }
}