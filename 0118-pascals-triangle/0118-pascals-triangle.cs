public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var ans = new List<IList<int>>();
        var row = new List<int>{ 1 };
        for(var i = 0; i < numRows; i++){
            ans.Add(row);
            row = GenerateRow(row);
        }

        return ans;
    }

    private List<int> GenerateRow(List<int> row){
        var next = new List<int>{ 1 };

        for(var i = 0; i < row.Count - 1; i++){
            next.Add(row[i] + row[i + 1]);
        }
        next.Add(1);

        return next;
    }
}