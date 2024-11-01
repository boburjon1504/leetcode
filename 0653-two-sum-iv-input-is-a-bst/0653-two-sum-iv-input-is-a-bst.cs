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
    public bool FindTarget(TreeNode root, int k) {
        var queue = new Queue<TreeNode>();

        var numFreq = new Dictionary<int, int>();

        queue.Enqueue(root);

        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                var num = node.val;
                if(!numFreq.ContainsKey(num)){
                    numFreq[num] = 0;
                }
                numFreq[num]++;
                var n = k - num;

                if((n == num && numFreq[num] == 2) || 
                (n != num && numFreq.ContainsKey(n))){
                    return true;
                }
                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
        }
        return false;
    }
}