public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        var sm = 0;
        var c = piles.Length / 3;
        for(var i = piles.Length - 2; i >= 0; i -= 2 ){
            sm += piles[i];
            c--;
            if(c == 0){
                break;
            }
        }
        return sm;

        // 1 2 3 4 5 6 7 8 9
    }
}