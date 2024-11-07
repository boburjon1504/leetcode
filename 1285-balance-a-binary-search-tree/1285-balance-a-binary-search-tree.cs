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
    public TreeNode BalanceBST(TreeNode root) {
        var items = new List<int>();

        InOrder(root, items);
        return MakeTree(items, 0, items.Count - 1);
    }

    private TreeNode MakeTree(IList<int> items, int l, int r){
        if(l > r){
            return null;
        }
        var md = (l + r) / 2;

        var node = new TreeNode(items[md]);

        node.left = MakeTree(items, l, md - 1);
        node.right = MakeTree(items, md + 1, r);

        return node;
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