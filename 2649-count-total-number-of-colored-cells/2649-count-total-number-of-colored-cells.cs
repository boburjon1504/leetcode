public class Solution {
    public long ColoredCells(int n) {
        return (long)Math.Pow(n, 2) + (long)Math.Pow(n - 1, 2);
    }
}