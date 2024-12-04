public class StockSpanner {
    private Stack<int> stack;
    public StockSpanner() {
        stack = new Stack<int>();
    }
    
    public int Next(int price) {
        var s = new Stack<int>();
        var c = 1;
        while(stack.Count > 0 && stack.Peek() <= price){
            var el = stack.Pop();
            s.Push(el);
            c++;
        }

        while(s.Count > 0){
            var el = s.Pop();
            stack.Push(el);
        }

        stack.Push(price);

        return c;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */