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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if(root is null) return [];
        var levels = new List<IList<int>>();

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var depth = 0;
        while(queue.Count > 0){
            var size = queue.Count;
            var s = new Stack<int>();
            var q = new Queue<int>();
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(depth % 2 == 1){
                    s.Push(node.val);
                }else{
                    q.Enqueue(node.val);
                }
                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
            if(depth % 2 == 0){
                levels.Add(q.ToList());
            }else{
                levels.Add(s.ToList());
            }
            depth++;
        }

        return levels;
    
    }
}