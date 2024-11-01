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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var res = new List<IList<int>>();

        PathSum(root, targetSum, res, "", 0);

        return res;
    }

    private void PathSum(TreeNode root, int target,IList<IList<int>> res, string nums, int sm){
        if(root is null){
            return;
        }
        sm += root.val;
        nums += $",{root.val}";
        if(root.left is null && root.right is null && sm == target){
            res.Add(nums.Split(',').Where(x => x.Length > 0)
                                .Select(x => int.Parse(x)).ToList());
        }

        PathSum(root.left, target, res, nums, sm);
        if(root.right is null){
            sm -= root.val;
            nums = nums.Substring(0, nums.Length - 1);
        }
        PathSum(root.right, target, res, nums, sm);
    }
}