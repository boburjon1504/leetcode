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
    public bool IsSymmetric(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            var size = queue.Count;
            var elem = new List<TreeNode>();
            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                elem.Add(node);

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }

            for(var i = 0; i < elem.Count; i++){
                var last = elem[elem.Count - 1 - i];
                if(elem[i].left is null && elem[i].right is null && last.left is null && last.right is null){
                    continue;
                }
                if(elem[i].left is null && last.right is null && elem[i].right != null &&
                last.left != null && elem[i].right.val == last.left.val){
                    continue;
                }
                if(elem[i].left is null && last.right is null && elem[i].right != null &&
                last.left != null && elem[i].right.val != last.left.val){
                    return false;
                }
                if(elem[i].right is null && last.left is null && elem[i].left != null &&
                last.right != null && elem[i].left.val == last.right.val){
                    continue;
                }
                if(elem[i].right is null && last.left is null && elem[i].left != null &&
                last.right != null && elem[i].left.val != last.right.val){
                    return false;
                }
                if((elem[i].left is null && last.right is not null) ||
                (elem[i].left is not null && last.right is null) ||
                (elem[i].right is null && last.left is not null)||
                (elem[i].right is not null && last.left is null) ||
                (elem[i].left.val != last.right.val)||
                (elem[i].right.val != last.left.val)){
                    return false;
                }
            }
        }

        return true;
    }
}