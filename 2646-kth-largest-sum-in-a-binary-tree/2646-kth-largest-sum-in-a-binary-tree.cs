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
using System.Text.Json;

public class Solution {
    public long KthLargestLevelSum(TreeNode root, int k) {
        int a = 0, b = 0;

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        var ls = new List<long>();
        while(queue.Count > 0){
            var size = queue.Count;
            long sm = 0;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();

                sm += node.val;

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }

            ls.Add(sm);
        }

        ls = ls.Order().ToList();
        if(k > ls.Count){
            return -1;
        }

        return ls[ ls.Count - k];
    }
}