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
    private readonly Dictionary<int,TreeNode> _nodes = 
                    new Dictionary<int, TreeNode>();

    private readonly Dictionary<TreeNode,bool> _nodeWithType = new Dictionary<TreeNode, bool>();
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        foreach(var pairs in descriptions) {
            (var parent, var child, var isLeft) = (pairs[0], pairs[1], pairs[2]);
            AddNodeIfNotExist(parent, true);
            AddNodeIfNotExist(child, false);

            AddChild(_nodes[parent], _nodes[child], isLeft == 1);

            _nodeWithType[_nodes[child]] = false;
        }
        foreach(var (key, isParent) in _nodeWithType) {
            if(isParent){
                return key;
            }
        }

        return null;
    }

    private void AddChild(TreeNode parent, TreeNode child, bool isLeft) {
        if(isLeft){
            parent.left = child;
        }else{
            parent.right = child;
        }
    }

    private void AddNodeIfNotExist(int val, bool isParent){
        if(!_nodes.ContainsKey(val)){
            _nodes[val] = new TreeNode(val);
            _nodeWithType[_nodes[val]] = isParent;
        }
    }
}