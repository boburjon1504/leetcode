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
    public ListNode ReverseEvenLengthGroups(ListNode head) {
        var c = 1;
        var temp = head;
        var prev = temp;

        while(temp is not null){
            var t = 1;
            var cur = temp;
            while(cur is not null && t < c){
                cur = cur.next;
                t++;
            }
            if((t % 2 == 0 && cur is not null) || (cur is null && t % 2 == 1)){
                cur = temp;
                ListNode pr = null;
                ListNode tail = cur;
                while(cur is not null && t > 0){
                    var next = cur.next;
                    cur.next = pr;
                    pr = cur;
                    cur = next;
                    t--;
                }
                prev.next = pr;
                prev = tail;
                tail.next = cur;
                temp = cur;
            }else{
                while(temp is not null && t > 0){
                    prev = temp;
                    temp = temp.next;
                    t--;
                }
            }
            c++;
        }

        return head;
    }
}