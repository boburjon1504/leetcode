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
    public IList<int> Postorder(Node root) {
        if(root is null) return [];
        var ls = new List<int>();

        PostOrder(root, ls);

        return ls;
    }

    private void PostOrder(Node root, IList<int> ls){
        if(root.children is null){
            ls.Add(root.val);
            return;
        }

        foreach(var node in root.children){
            PostOrder(node, ls);
        }
        ls.Add(root.val);
    }
}