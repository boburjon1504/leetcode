public class MyLinkedList {
    public class  Node{
        public Node next;
        public int val;
        public Node(int val) => this.val = val;
    }

    private Node root;
    public MyLinkedList() {
        
    }
    
    public int Get(int index) {
        Console.WriteLine(index);
        if(root is null){
            return -1;
        }
        var temp = root;
        while(index > 0 && temp is not null){
            temp = temp.next;
            index--;
        }

        return index > 0 || temp is null ? -1 : temp.val; 
    }
    
    public void AddAtHead(int val) {
        var node = new Node(val);

        node.next = root;
        root = node;
    }
    
    public void AddAtTail(int val) {
        if(root is null){
            root = new Node(val);
            return;
        }
        var temp = root;

        while(temp.next is not null){
            temp = temp.next;
        }

        temp.next = new Node(val);
    }
    
    public void AddAtIndex(int index, int val) {
        Node prev = null;
        var temp = root;
        while(index > 0 && temp is not null){
            index--;
            prev = temp;
            temp = temp.next;
        }
        if(index > 0){
            return;
        }
        if(prev == null){
            var node = new Node(val);
            node.next = root;
            root = node;
        }else{
            var next = prev.next;
            prev.next = new Node(val);
            prev.next.next = next;
        }
    }
    
    public void DeleteAtIndex(int index) {
        Console.WriteLine(index);
        Node prev = null;
        var temp = root;
        while(index > 0 && temp is not null){
            prev = temp;
            temp = temp.next;
            index--;
        }
        if(index > 0 || root is null){
            return;
        }
        if(prev is null){
            root = root.next;
        }else if(temp is null){
            prev.next = null;
        }
        else{
            prev.next = temp.next;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */