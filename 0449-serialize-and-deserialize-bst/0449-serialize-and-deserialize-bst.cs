/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Text.Json;
public class Codec {
    public string serialize(TreeNode root) {
        if(root is null){
            return "";
        }

        var queue = new Queue<(TreeNode node, int i)>();

        queue.Enqueue((root, 0));

        var dc = new Dictionary<int, int>();
        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var pair = queue.Dequeue();
                var node = pair.node;
                var index = pair.i;
                dc[index] = node.val;
                if(node.left is not null) queue.Enqueue((node.left, index * 2 + 1));
                if(node.right is not null) queue.Enqueue((node.right, index * 2 + 2));
            }
        }

        return JsonSerializer.Serialize(dc);
    }
    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data.Length == 0){
            return null;
        }
        var dc = JsonSerializer.Deserialize<Dictionary<int, int>>(data);
        var ans = new Dictionary<int, TreeNode>();

        foreach(var node in dc){
            var i = node.Key;
            var val = node.Value;
            if(i == 0){
                ans[i] = new TreeNode(val);
            }else{
                var pIndex = i % 2 == 0 ? i / 2 - 1 : i / 2;
                var parent = ans[pIndex];
                var newNode = new TreeNode(val);
                if(i % 2 == 0){
                    parent.right = newNode;
                }else{
                    parent.left = newNode;
                }
                ans[i] = newNode;
            }
        }

        return ans[0];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;