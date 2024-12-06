public class Solution
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        var ban = banned.ToHashSet();
        var sm = 0;
        var cnt = 0;
        for (var i = 1; i <= n; i++)
        {
            if (banned.Contains(i)){
                continue;
            }

            if(sm + i <= maxSum){
                sm += i;
                cnt++;
            }else{
                return cnt;
            }
        }

        return cnt;
    }
}