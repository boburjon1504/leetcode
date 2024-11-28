public class BrowserHistory {
    private readonly Stack<string> visits;
    private readonly Stack<string> forward;
    public BrowserHistory(string homepage) {
        visits = new Stack<string>();
        forward = new Stack<string>();

        visits.Push(homepage);
    }
    
    public void Visit(string url) {
        visits.Push(url);
        forward.Clear();
    }
    
    public string Back(int steps) {
        while(steps > 0 && visits.Count > 1){
            var url = visits.Pop();
            forward.Push(url);
            steps--;
        }
        
        return visits.Count >= 1 ? visits.Peek() : forward.Peek();
    }
    
    public string Forward(int steps) {
        while(steps > 0 && forward.Count > 0){
            var url = forward.Pop();
            visits.Push(url);
            steps--;
        }
        
        return visits.Peek();
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */