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
    public TreeNode ReverseOddLevels(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var depth = 0;
        while(queue.Count > 0){
            var level = new List<TreeNode>();
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(node.left is not null){
                    queue.Enqueue(node.left);
                    level.Add(node.left);
                }
                if(node.right is not null){
                    queue.Enqueue(node.right);
                    level.Add(node.right);
                }
            }
            depth++;
            if(depth % 2 == 1){
                Reverse(level, 0, level.Count - 1);
            }
        }

        return root;
    }
    private void Reverse(List<TreeNode> nodes, int l, int r){
        if(l >= r){
            return;
        }
        (nodes[l].val, nodes[r].val) = (nodes[r].val, nodes[l].val);

        Reverse(nodes,l + 1, r - 1);
    }
}