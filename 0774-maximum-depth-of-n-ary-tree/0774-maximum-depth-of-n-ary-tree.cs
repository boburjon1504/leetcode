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
    public int MaxDepth(Node root) {
        if(root is null){
            return 0;
        }
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        var depth = 0;
        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();

                foreach(var child in node.children){
                    queue.Enqueue(child);
                }
            }
            depth++;
        }

        return depth;
    }
}