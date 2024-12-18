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
using System.Linq;
using System.Text.Json;
public class Solution {
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var queue = new Queue<(TreeNode node, int row, int col)>();

        queue.Enqueue((root, 0, 0));
        var dc = new Dictionary<int, IList<int>>();
        while(queue.Count > 0){
            var size = queue.Count; 
            var cd = new Dictionary<int, IList<int>>();
            for(var i = 0; i < size; i++){
                (var node, var row, var col) = queue.Dequeue();
                if(!cd.ContainsKey(col)){
                    cd[col] = new List<int>();
                }
                cd[col].Add(node.val);

                if(node.left is not null) queue.Enqueue((node.left,row+1, col - 1));
                if(node.right is not null) queue.Enqueue((node.right,row+1, col + 1));
            }
            foreach(var x in cd){
                if(x.Value.Count > 1){
                    cd[x.Key] = cd[x.Key].Order().ToList();
                }
                if(!dc.ContainsKey(x.Key)){
                    dc[x.Key] = new List<int>();
                }
                foreach(var i in cd[x.Key]){
                    dc[x.Key].Add(i);
                }
            }
        }
        return dc.OrderBy(x => x.Key).Select(x => x.Value).ToList();
    }
}