public class Solution {
    public int Trap(int[] height) {
        var totalSum = 0;
        var stack = new Stack<int>();
        foreach(var h in height){
            if(stack.Count == 0){
                if(h == 0) continue;
                stack.Push(h);
            }else if(stack.Peek() > h){
                stack.Push(h);
            }else{
                var subSum = 0;
                var count = 0;
                var last = 0;
                while(stack.Count > 0 && stack.Peek() < h){
                    var n = stack.Pop();
                    last = n;
                    subSum += (h - n);
                    count++;
                }
                
                if(stack.Count == 0){
                    var c = 0;
                    while(c < count){
                        subSum -= (h - last);
                        c++;
                    }
                }
                if(stack.Count > 0){
                    while(count > 0){
                        stack.Push(h);
                        count--;
                    }
                }
                stack.Push(h);
                totalSum += subSum;
            }
        }

        return totalSum;
    }
}