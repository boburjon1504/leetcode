/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        var c = 0;
        var cur = head;
        while(cur is not null){
            if(cur.child is not null){
                var next = cur.next;
                var child = cur.child;
                (cur.next, child.prev) = (child, cur);
                var temp = child;
                while(temp.next is not null){
                    temp = temp.next;
                }
                if(next is not null){
                    next.prev = temp;
                }
                temp.next = next;
                
                cur.child = null;
            }
            cur = cur.next;
        }

        return head;        
    }
}