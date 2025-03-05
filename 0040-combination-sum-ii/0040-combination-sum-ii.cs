public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates); 
        var result = new List<IList<int>>();
        Comb(target, candidates, 0, new List<int>(), result);
        return result;
    }

    private void Comb(
        int target, int[] candidates, int index, 
        List<int> current, IList<IList<int>> result) {

        if (target == 0) {
            result.Add(new List<int>(current)); 
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            if (i > index && candidates[i] == candidates[i - 1]) {
                continue; 
            }

            if (candidates[i] > target) {
                break;
            }

            current.Add(candidates[i]);
            Comb(target - candidates[i], candidates, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}