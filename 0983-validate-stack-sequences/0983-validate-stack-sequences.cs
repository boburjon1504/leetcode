public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var stack = new Stack<int>();
        var queue = new Queue<int>();

        for(var i = 0; i < pushed.Length; i++){
            stack.Push(pushed[i]);
            queue.Enqueue(popped[i]);
            while(stack.Count > 0 && queue.Count > 0 && stack.Peek() == queue.Peek()){
                stack.Pop();
                queue.Dequeue();
            }
        }

        return stack.Count == 0 && queue.Count == 0;
    }
}