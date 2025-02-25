public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();

        foreach(var a in asteroids){
            if(stack.Count == 0){
                stack.Push(a);
            }else{
                if(a > 0){
                    stack.Push(a);
                }else{
                    var abs = Math.Abs(a);
                    while(stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < abs){
                        stack.Pop();
                    }
                    if(stack.Count == 0){
                        stack.Push(a);
                    }else if(stack.Peek() == abs){
                        stack.Pop();
                    }else if(stack.Peek() < 0){
                        stack.Push(a);
                    }
                }
            }
        }

        return stack.Reverse().ToArray();
    }
}