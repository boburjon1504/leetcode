/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        var ls = new List<int>();
        if(root is null) return ls;

        PreOrder(root, ls);

        return ls;
    }

    private void PreOrder(Node root, IList<int> ls){
        if(root.children is null){
            ls.Add(root.val);
        }
        ls.Add(root.val);
        foreach(var node in root.children){
            PreOrder(node, ls);
        }
    }
}