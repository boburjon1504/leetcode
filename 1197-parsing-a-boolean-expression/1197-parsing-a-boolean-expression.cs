public class Solution {
    public bool ParseBoolExpr(string expression) {
        var punct = new Stack<char>();
        var expres = new Stack<char>();
        var ans = false;
        foreach(var i in expression){
            if(i == ','){
                continue;
            }

            if("&|!".Any(x => x == i)){
                punct.Push(i);
            }else
            if(i != ')'){
                expres.Push(i);
            }else{
                ans = expres.Pop() == 't';
                var p = punct.Pop();
                while(expres.Peek() != '('){
                    var a = expres.Pop();
                    if(p == '&'){
                        ans = ans && a == 't';
                    }else if(p == '|'){
                        ans = ans || a == 't';
                    }
                }
                if(p == '!'){
                    ans = !ans;
                }
                expres.Pop();
                expres.Push(ans ? 't' : 'f');
            }

        }
        if(expres.Count > 0){
            ans = expres.Pop() == 't';
        }
        return ans;
    }
}