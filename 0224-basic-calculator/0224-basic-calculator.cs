public class Solution {
    private string _s;
    public int Calculate(string s) {
       _s = s.Replace(" ","");

       while(_s.Contains('(')){
            var i = 0;
            var l = 0;
            while(i < _s.Length){
                if(_s[i] == '('){
                    l = i;
                }else if(_s[i] == ')'){
                    var res = Calculate(l + 1, i);
                    _s = _s.Substring(0,l) + res + _s.Substring(i + 1);
                    break;
                }
                i++;
            }
       }
        
       return Calculate(0, _s.Length);
    }

    private int Calculate(int l, int r){
        var num = 0;
        var n = new StringBuilder();
        while(l < r){
            if(n.Length == 1 && n[0] == _s[l] && n[0] == '-'){
                l++;
                n = new StringBuilder();
                continue;
            }
            if(n.Length == 1 && n[0] == '+' && _s[l] == '-'){
                l++;
                n = new StringBuilder();
                n.Append('-');
                continue;
            }
            if(n.Length > 0 && "+-".Contains(_s[l])){
                num += int.Parse(n.ToString());
                n = new StringBuilder();
            }

            n.Append(_s[l]);
            l++;
        }
        num += int.Parse(n.ToString());
        return num;
    }
}