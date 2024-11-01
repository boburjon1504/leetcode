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
    public bool IsCousins(TreeNode root, int x, int y) {
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        var xExist = false;
        var yExist = false;
        while(queue.Count > 0){
            var size = queue.Count;
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(xExist && yExist) return true;

                if(node.left is not null){
                    queue.Enqueue(node.left);
                    if(node.left.val == x){
                        if(node.right is not null) queue.Enqueue(node.right);    
                        xExist = true;
                        continue;
                    }
                    if(node.left.val == y){
                        yExist = true;
                        if(node.right is not null) queue.Enqueue(node.right);

                        continue;
                    }
                } 
                if(node.right is not null){
                    if(node.right.val == x){
                        xExist = true;
                    }else
                    if(node.right.val == y){
                        yExist = true;
                    }
                    queue.Enqueue(node.right);
                }
            }
            if(xExist && yExist) return true;

            xExist = false;
            yExist = false;
        }
        return false;
    }
}