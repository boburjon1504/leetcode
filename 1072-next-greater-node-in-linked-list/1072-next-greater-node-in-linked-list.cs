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
    public int[] NextLargerNodes(ListNode head) {
        var temp = head;
        var values = new List<int>();
        var stack = new Stack<int>();
        while(temp is not null){
            values.Add(temp.val);
            temp = temp.next;
        }

        var ans = new int[values.Count];

        for (int i = 0; i < values.Count; i++)
        {
            while (stack.Count > 0 && values[stack.Peek()] < values[i])
            {
                ans[stack.Pop()] = values[i];
            }

            stack.Push(i);
        }

        while(stack.Count > 0){
            ans[stack.Pop()] = 0;
        }

        return ans;
        
    }
}