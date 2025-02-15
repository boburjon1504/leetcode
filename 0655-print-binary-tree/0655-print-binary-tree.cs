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
    public IList<IList<string>> PrintTree(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var depth = 0;

        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();

                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }

            depth++;
        }
        var arr = new string[depth][]
                            .Select(_ => new string[(int)Math.Pow(2, depth) - 1]
                            .Select(_ => "").ToArray())
                            .ToArray();
        

        var q = new Queue<(TreeNode node, int i)>();
        q.Enqueue((root, ((int) Math.Pow(2,depth) - 1) / 2));
        var r = 0;
        while(q.Count > 0){
            var size = q.Count;

            for(var i = 0; i < size; i++){
                var pair = q.Dequeue();
                arr[r][pair.i] = pair.node.val.ToString();

                if(pair.node.left is not null) {
                    q.Enqueue((pair.node.left, pair.i - (int)Math.Pow(2, depth - r - 2)));
                }

                if(pair.node.right is not null){
                    q.Enqueue((pair.node.right, pair.i + (int)Math.Pow(2, depth - r - 2)));
                }
            }

            r++;
        }
        var ans = new List<IList<string>>();

        foreach(var a in arr){
            var ls = new List<string>();
            foreach(var b in a){
                ls.Add(b);
            }
            ans.Add(ls);
        }
        return ans;
    }
}