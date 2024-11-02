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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        if(root is null){
            return [];
        }
        var stack = new Stack<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            var size = queue.Count;
            var level = new List<int>();
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                level.Add(node.val);

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
            stack.Push(level);
        }

        return stack.ToList();
    }
}