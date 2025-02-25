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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root is null){
            return null;
        }
        if(root.val == key && root.left is null && root.right is null){
            return null;
        }
        if(root.val == key){
            if(root.left is null){
                return root.right;
            }else if(root.right is null){
                return root.left;
            }else{
                var child = GetChild(root.right);
                (child.left, child.right) = (root.left, root.right == child ? root.right.right : root.right);

                return child;
            }
        }
        Delete(root, root, key);

        return root;
    }

    private void Delete(TreeNode root, TreeNode parent,int key){
        if(root is null){
            return;
        }

        if(root.val == key && root.left is null && root.right is null){
            if(parent.left == root){
                parent.left = null;
            }else{
                parent.right = null;
            }
            return;
        }
        
        if(root.val == key){
            if(root.right is null){
                if(parent.left == root){
                    parent.left = root.left;
                }else{
                    parent.right = root.left;
                }
            }else if(root.left is null){
                if(parent.left == root){
                    parent.left = root.right;
                }else{
                    parent.right = root.right;
                }
            }else{
                var child = GetChild(root.right);
                Console.WriteLine("Ishladi");
                (child.left, child.right) = (root.left, root.right == child ? root.right.right : root.right);
                if(parent.left == root){
                    parent.left = child;
                }else{
                    parent.right = child;
                }
            }

            return;
        }

        Delete(root.left, root, key);
        Delete(root.right, root, key);
    }

    private TreeNode GetChild(TreeNode root){
        var temp = root;
        var prev = temp;

        while(temp.left is not null){
            prev = temp;
            temp = temp.left;
        }
        
        prev.left = temp.right;

        return temp;
    }
}