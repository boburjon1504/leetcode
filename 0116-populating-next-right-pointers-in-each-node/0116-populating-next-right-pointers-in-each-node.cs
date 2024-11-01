/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root is null) return null;

        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            Node prev = null;
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();
                if(prev is null){
                    prev = node;
                }else{
                    prev.next = node;
                    prev = node;
                }
                if(node.left is not null) queue.Enqueue(node.left);
                if(node.right is not null) queue.Enqueue(node.right);
            }
        }
        return root;        
    }
}