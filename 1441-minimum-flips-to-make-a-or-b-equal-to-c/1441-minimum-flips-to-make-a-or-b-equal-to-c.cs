public class Solution {
    public int MinFlips(int a, int b, int c) {
        var binA = ToBinary(a);
        var binB = ToBinary(b);
        var binC = ToBinary(c);

        var mx = new List<int> { binA.Length, binB.Length, binC.Length }.Max();

        binA = binA.PadLeft(mx, '0');
        binB = binB.PadLeft(mx, '0');
        binC = binC.PadLeft(mx, '0');
        var count = 0;
        for(var i = 0; i < binC.Length; i++){
            var s = $"{binA[i]}{binB[i]}";

            if(binC[i] == '0' && s.Count(x => x == '1') == 2){
                count += 2;
            }else if(binC[i] == '0' && s.Count(x => x == '1') == 1){
                count++;
            }else if(binC[i] == '1' && s.Count(x => x == '1') == 0){
                count++;
            }
        }
        return count;
    }

    private string ToBinary(int n){
        if(n == 0){
            return "";
        }

        return ToBinary(n / 2) + n % 2;
    }
}