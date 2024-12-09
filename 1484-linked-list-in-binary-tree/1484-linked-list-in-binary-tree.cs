/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    public bool IsSubPath(ListNode head, TreeNode root) {
        return IsSub(root, head);
    }
    private bool IsSub(TreeNode root, ListNode head){
        if(root is null){
            return false;
        }
        if(IsSubPath(root, head, head)){
            return true;
        }

        return IsSub(root.left, head) || IsSub(root.right, head);
    }
    private bool IsSubPath(TreeNode root, ListNode head, ListNode temp){
        if(root is null){
            return false;
        }
        if(root.val == temp.val && temp.next is null){
            return true;
        }else if(temp.val == root.val){
            temp = temp.next;
        }else if(root.val != temp.val){
            temp = head;
        }

        return IsSubPath(root.left, head, temp) || IsSubPath(root.right, head, temp);
    }
}