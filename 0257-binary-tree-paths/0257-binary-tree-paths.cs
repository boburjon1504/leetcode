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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var paths = new List<string>();
        BinaryTreePaths(root, paths, "");

        return paths;
    }

    private void BinaryTreePaths(TreeNode root, IList<string> paths, string path){
        if(root is null){
            return;
        }

        if(root.left is null && root.right is null){
            path += root.val;
            paths.Add(path);
        }else{
            path += $"{root.val}->";
        }

        BinaryTreePaths(root.left, paths, path);
        if(root.right is null){
            path = path.Substring(0, path.Length - 1);
        }
        BinaryTreePaths(root.right, paths, path);


    }
}