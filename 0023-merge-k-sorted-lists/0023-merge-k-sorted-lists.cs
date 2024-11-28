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
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0){
            return null;
        }
        if(lists.Length == 1){
            return lists[0];
        }
        var head = Merge(lists[0], lists[1]);
        for(var i = 2; i < lists.Length; i++){
            head = Merge(head, lists[i]);
        }

        return head;
    }
    static ListNode Merge(ListNode head1, ListNode head2)
    {
        ListNode head = null;
        var temp = head2;
        while (head1 is not null && head2 is not null)
        {
            if (head1.val > head2.val)
            {
                if (head is null)
                {
                    head = new ListNode(head2.val);
                    temp = head;
                }
                else
                {
                    temp.next = new ListNode(head2.val);
                    temp = temp.next;
                }
                head2 = head2.next;
            }
            else
            {
                if (head is null)
                {
                    head = new ListNode(head1.val);
                    temp = head;
                }
                else
                {
                    temp.next = new ListNode(head1.val);
                    temp = temp.next;
                }
                head1 = head1.next;
            }

        }
        while (head1 is not null)
        {
            if(head is null){
                head = new ListNode(head1.val);
                temp = head;
            }else{
                temp.next = new ListNode(head1.val);
                temp = temp.next;
            }
            head1 = head1.next;
        }

        while (head2 is not null)
        {
            if(head is null){
                head = new ListNode(head2.val);
                temp = head;
            }else{
                temp.next = new ListNode(head2.val);
                temp = temp.next;
            }
            head2 = head2.next;
        }

        return head;
    }
}