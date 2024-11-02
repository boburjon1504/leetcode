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
    public IList<int> RightSideView(TreeNode root) {
        if(root is null){
            return [];
        }
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        var rightSide = new List<int>();

        while(queue.Count > 0){
            var size = queue.Count;
            var right = 0;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                right = node.val;

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }

            rightSide.Add(right);
        }
        return rightSide;
    }
}