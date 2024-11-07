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
    public TreeNode SortedListToBST(ListNode head) {
        if(head is null) return null;

        var ls = new List<int>();
        while(head is not null){
            ls.Add(head.val);
            head = head.next;
        }

        return MakeTree(ls, 0, ls.Count - 1);
    }

    private TreeNode MakeTree(IList<int> items, int l, int r){
        if(l > r) return null;

        var md = (l + r) / 2;

        var node = new TreeNode(items[md]);

        node.left = MakeTree(items, l, md - 1);
        node.right = MakeTree(items, md + 1, r);

        return node;
    }
}