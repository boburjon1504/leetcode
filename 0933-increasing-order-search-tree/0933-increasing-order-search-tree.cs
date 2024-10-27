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
    public TreeNode IncreasingBST(TreeNode root) {
        var items = new List<int>();
        InOrderTraversal(root, items);
        var head = new TreeNode(items[0]);
        var temp = head;
        for(var i = 1; i < items.Count; i++){
            temp.right = new TreeNode(items[i]);
            temp = temp.right;
        }
        return head;  
    }

    private void InOrderTraversal(TreeNode root,List<int> items){
        if(root is null){
            return;
        }

        InOrderTraversal(root.left, items);
        items.Add(root.val);
        InOrderTraversal(root.right, items);
    }
}