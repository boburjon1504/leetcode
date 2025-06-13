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
using System.Text.Json;
public class Solution {
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var duplicates = new List<TreeNode>();

        Find(root, new(), duplicates);

        return duplicates;
    }

    private static string Find(TreeNode root, Dictionary<string, bool> set, IList<TreeNode> duplicates){
        if(root is null){
            return ",null,";
        }

        var path = $",{root.val}," + Find(root.left, set, duplicates) + Find(root.right, set, duplicates);

        if(set.ContainsKey(path) && set[path]){
            duplicates.Add(root);
            set[path] = false;
        }else if(!set.ContainsKey(path)){
            set[path] = true;
        }

        return path;
    }
}