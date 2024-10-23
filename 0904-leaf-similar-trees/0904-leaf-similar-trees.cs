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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var list1 = new List<int>();
        var list2 = new List<int>();

        InOrder(root1, list1);
        InOrder(root2, list2);

        return list1.SequenceEqual(list2);
    }

    private void InOrder(TreeNode root, List<int> list){
        if(root is null){
            return;
        }

        InOrder(root.left, list);
        if(root.left is null && root.right is null){
            list.Add(root.val);
        }
        InOrder(root.right, list);
    }
}