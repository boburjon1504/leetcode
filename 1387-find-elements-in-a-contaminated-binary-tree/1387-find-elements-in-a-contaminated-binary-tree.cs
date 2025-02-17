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
public class FindElements {
    private HashSet<int> elems;
    public FindElements(TreeNode root) {
        elems = new HashSet<int>();
        StoreInSet(root);
    }
    
    private void StoreInSet(TreeNode root){
        var queue = new Queue<TreeNode>();
        root.val = 0;
        queue.Enqueue(root);

        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var node = queue.Dequeue();

                elems.Add(node.val);

                if(node.left is not null){
                    node.left.val = node.val * 2 + 1;
                    queue.Enqueue(node.left);
                }
                if(node.right is not null){
                    node.right.val = node.val * 2 + 2;
                    queue.Enqueue(node.right);
                }
            }
        }
    }
    
    public bool Find(int target) {
        return elems.Contains(target);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */