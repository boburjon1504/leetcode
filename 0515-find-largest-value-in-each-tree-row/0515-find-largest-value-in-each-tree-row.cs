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
    public IList<int> LargestValues(TreeNode root) {
        if(root is null){
            return [];
        }
        var res = new List<int>();

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while(queue.Count > 0){
            var size = queue.Count;
            var mx = -2147483648;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(node.val > mx){
                    mx = node.val;
                }

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }

            res.Add(mx);
        }

        return res;
    }
}