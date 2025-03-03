/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node is null) return null;

        var clone = new Node(node.val);

        var queue = new Queue<Node>();
        var dc = new Dictionary<int, Node>();
        dc[clone.val] = clone;
        queue.Enqueue(node);
        while(queue.Count > 0){
            var nd = queue.Dequeue();
            var newNode = dc[nd.val];
            var neighbors = new List<Node>();
            foreach(var n in nd.neighbors){
                if(!dc.ContainsKey(n.val)){
                    queue.Enqueue(n);
                    dc[n.val] = new Node(n.val);
                }
                neighbors.Add(dc[n.val]);
            }
            newNode.neighbors = neighbors;
        } 

        return clone;
    }

    private Node Clone(Node node, Node clone, Dictionary<int, Node> set){
        if(node is null) return clone;

        if(set.ContainsKey(node.val)) return set[node.val];
        clone = new Node(node.val);

        if(node.neighbors.Count == 0) return clone;
        var neighbors = node.neighbors;
        var ans = new List<Node>();
        for(var i = 0; i < neighbors.Count; i++){
            ans.Add(Clone(neighbors[i], null, set));
        }

        clone.neighbors = ans;
        set[node.val] = clone;

        return clone;
    }
}