public class TextEditor {
    public Node cur;
    public TextEditor() {
        cur = new Node();
    }
    
    public void AddText(string text) {
        var next = cur.next;
        foreach(var t in text){
            cur.next = new Node(t);
            var prev = cur;
            cur = cur.next;
            cur.prev = prev;
        }
        if(next is not null){
            next.prev = cur;
        }
        cur.next = next;
    }
    
    public int DeleteText(int k) {
        var c = 0;
        var next = cur.next;
        while(k > 0 && cur is not null){
            k--;
            c++;
            if(cur is not null && !cur.val.HasValue){
                c--;
                break;
            }
            cur = cur.prev;
        }
        if(next is not null){
            next.prev = cur;
        }
        cur.next = next;

        return c;
    }
    
    public string CursorLeft(int k) {
        var next = cur.next;
        while(k > 0 && cur is not null){
            k--;
            if(!cur.val.HasValue){
                break;
            }
            cur = cur.prev;
        }
        if(cur is null){
            cur = new Node();
            cur.next = next;
        }
        var temp = cur;
        var c = 10;
        var stringB = new StringBuilder();
        while(c > 0 && temp is not null){
            c--;
            if(!temp.val.HasValue){
                break;
            }
            stringB.Append(temp.val.Value);
            temp = temp.prev;
        }

        return string.Join("",stringB.ToString().Reverse());
    }
    
    public string CursorRight(int k) {
        var prev = cur;
        while(k > 0 && cur is not null){
            k--; 
            prev = cur;
            cur = cur.next;
        }
        if(cur is null){
            cur = prev;
        }

        var temp = cur;
        var c = 10;
        var stringB = new StringBuilder();
        while(c > 0 && temp.val.HasValue){
            c--;

            stringB.Append(temp.val.Value);
            temp = temp.prev;
        }

        return string.Join("",stringB.ToString().Reverse());
    }
}
public    class Node{
        public Node prev;
        public Node next;
        public char? val;
        public Node(char? val = null, Node prev = null, Node next = null){
            this.prev = prev;
            this.next = next;
            this.val = val;
        }
    }

/**
 * Your TextEditor object will be instantiated and called as such:
 * TextEditor obj = new TextEditor();
 * obj.AddText(text);
 * int param_2 = obj.DeleteText(k);
 * string param_3 = obj.CursorLeft(k);
 * string param_4 = obj.CursorRight(k);
 */