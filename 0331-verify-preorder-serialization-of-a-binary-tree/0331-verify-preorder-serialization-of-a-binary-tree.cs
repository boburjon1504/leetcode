public class Solution {
    public bool IsValidSerialization(string preorder) {
        var tree = preorder.Split(',');
        var stack = new Stack<string>();
        foreach(var node in tree){

            if(stack.Count > 0 && stack.Peek() == "#" && node == "#"){
                stack.Pop();
                if(stack.Count == 0){
                    return false;
                }
                stack.Pop();

                while(stack.Count > 0 && stack.Peek() == "#"){
                    stack.Pop();
                    if(stack.Count == 0){
                        return false;
                    }
                    stack.Pop();
                }
                stack.Push(node);
            }else{
                stack.Push(node);
            }
        }
        Console.WriteLine(string.Join(" ", stack));
        return stack.Count == 1 && stack.Peek() == "#";
    }
}