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
    public TreeNode ConvertBST(TreeNode root) {
        if(root is null){
            return root;
        }
        var items = new List<TreeNode>();

        InOrder(root, items);
        var prefix = new int[items.Count];
        prefix[0] = items[0].val;
        for(var i = 1; i < items.Count; i++){
            prefix[i] += (items[i].val + prefix[i - 1]);
        }
        var last = prefix[prefix.Length - 1];
        for(var i = 0; i < prefix.Length; i++){
            items[i].val = last - prefix[i] + items[i].val;
        }

        return root;
    }
    private void InOrder(TreeNode root, List<TreeNode> items){
        if(root is null){
            return;
        }

        InOrder(root.left, items);
        items.Add(root);
        InOrder(root.right, items);
    }
}