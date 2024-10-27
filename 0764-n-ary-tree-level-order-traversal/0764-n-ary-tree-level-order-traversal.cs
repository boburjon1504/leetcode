/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        if(root is null){
            return null;
        }
        var res = new List<IList<int>>();

        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0){
            var level = new List<int>();
            var levelSize = queue.Count;

            for(var i = 0; i < levelSize; i++){
                var node = queue.Dequeue();
                level.Add(node.val);

                foreach(var child in node.children){
                    queue.Enqueue(child);
                }
            }
            res.Add(level);
        }

        return res;
    }
}