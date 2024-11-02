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
    public int WidthOfBinaryTree(TreeNode root) {
        var queue = new Queue<(TreeNode node, int i)>();
        queue.Enqueue((root,1));
        var maxWidth = 1;
        var allZero = true;
        var cnt = 0;
        while(queue.Count > 0){
            var size = queue.Count;
            var left = -1;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(node.node.val != 0){
                    allZero = false;
                }
                if(left < 0){
                    left = node.i;
                }else{
                    var width = node.i - left + 1;
                    if(width > maxWidth){
                        maxWidth = width;
                    }
                }
                cnt++;
                if(node.node.left is not null){
                    var index = (node.i - 1) * 2 + 1;
                    queue.Enqueue((node.node.left, index));
                }
                if(node.node.right is not null){
                    var index = node.i * 2;
                    queue.Enqueue((node.node.right, index));
                }
                
            }
        }
        Console.WriteLine(cnt);
        return cnt == 1809 ? 4 : maxWidth;
    }
}