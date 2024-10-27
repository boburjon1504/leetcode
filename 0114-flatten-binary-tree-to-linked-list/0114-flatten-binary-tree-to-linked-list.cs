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
    public void Flatten(TreeNode root) {
        var items = new List<int>();
        if(root is null){
            return;
        }
        PreOrder(root, items);
        var temp = root;
        for(var i = 0; i < items.Count; i++){
            temp.val = items[i];
            temp.left = null;
            if(i != items.Count - 1){
                temp.right = new TreeNode();
                temp = temp.right;
            }
        }
    }
    public void PreOrder(TreeNode root, List<int> items){
        if(root is null){
            return;
        }

        items.Add(root.val);

        PreOrder(root.left, items);
        PreOrder(root.right, items);
    }
}