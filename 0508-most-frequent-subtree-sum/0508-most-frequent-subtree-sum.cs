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
    public int[] FindFrequentTreeSum(TreeNode root) {
        var freq = new Dictionary<int, int>();

        Traverse(root, freq);

        var maxFreq = freq.Values.Max();

        var res = new List<int>();

        foreach(var (key, val) in freq){
            if(val == maxFreq){
                res.Add(key);
            }
        }

        return res.ToArray();
    }

    private int Traverse(TreeNode root, Dictionary<int, int> freq){
        if(root is null){
            return 0;
        }

        var leftSum = Traverse(root.left, freq);
        var rightSum = Traverse(root.right, freq);

        var totalSum = leftSum + rightSum + root.val;

        if(!freq.ContainsKey(totalSum)){
            freq[totalSum] = 0;
        }

        freq[totalSum]++;

        return totalSum;
    }
}