public class MyCircularDeque {
    public class Node{
        public int val;
        public Node next;
        public Node prev;
        public Node(int v)=> val = v;
    }
    private Node head;
    private Node tail;
    private int size;
    private int currentSize=0;
    public MyCircularDeque(int k) {
        size = k;
    }
    
    public bool InsertFront(int value) {
        if(IsFull()){
            return false;
        }
        currentSize++;

        if(head is null){
            head = new Node(value);
            tail = head;
        }else{
            var newNode = new Node(value);
            head.prev = newNode;
            newNode.next = head;
            head = newNode;
        }

        return true;
    }
    
    public bool InsertLast(int value) {
        if(IsFull()){
            return false;
        }

        currentSize++;

        if(tail is null){
            tail = new Node(value);
            head = tail;
        }else{
            var newNode = new Node(value);
            newNode.prev = tail;
            tail.next = newNode;
            tail = tail.next;
        }

        return true;
    }
    
    public bool DeleteFront() {
        if(IsEmpty()){
            return false;
        }
        currentSize--;
        if(IsEmpty()){
            tail = null;
            head = null;
            return true;
        }
        head = head.next;

        return true;
    }
    
    public bool DeleteLast() {
        if(IsEmpty()){
            return false;
        }
        currentSize--;
        if(IsEmpty()){
            head = null;
            tail = null;
            return true;
        }
        
        tail = tail.prev;
        tail.next = null;

        return true;

    }
    
    public int GetFront() {
        if(IsEmpty()){
            return -1;
        }

        return head.val;
    }
    
    public int GetRear() {
        if(IsEmpty()){
            return -1;
        }

        return tail.val;
    }
    
    public bool IsEmpty() {
        return currentSize == 0;
    }
    
    public bool IsFull() {
        return currentSize == size;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */