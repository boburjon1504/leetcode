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
    public bool IsValidBST(TreeNode root) {        
        var items = new List<int>();

        InOrder(root, items);
        var orders = items.Order();

        return items.SequenceEqual(orders) && items.ToHashSet().Count == items.Count;
    }
    private void InOrder(TreeNode root, List<int> items){
        if(root is null){
            return;
        }
        
        InOrder(root.left, items);
        items.Add(root.val);
        InOrder(root.right, items);
    }
}
