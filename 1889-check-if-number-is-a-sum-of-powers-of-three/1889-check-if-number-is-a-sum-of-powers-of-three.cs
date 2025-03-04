public class Solution {
    public bool CheckPowersOfThree(int n) {
        var ls = new List<int>();
        var power = 1;

        while(power <= n){
            ls.Add(power);
            power *= 3;
        }

        return IsPower(n, ls, new());
    }

    private bool IsPower(
        int n, 
        IList<int> nums, 
        HashSet<int> comb){
        
        if(n == 0) return true;
        if(n < 0) return false;

        foreach(var i in nums){
            if(comb.Contains(i)) return false;

            comb.Add(i);

            if(IsPower(n - i, nums, comb)){
                return true;
            }

            comb.Remove(i);
        }
        return false;
    }
}