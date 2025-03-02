public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        int i = 0, j = 0;
        var ans = new List<int[]>();
        while(i < nums1.Length && j < nums2.Length){
            if(nums1[i][0] == nums2[j][0]){
                ans.Add([nums1[i][0], nums1[i][1] + nums2[j][1]]);
                i++;
                j++;
            }else if(nums1[i][0] < nums2[j][0]){
                ans.Add(nums1[i]);
                i++;
            }else{
                ans.Add(nums2[j]);
                j++;
            }
        }

        while(i < nums1.Length){
            ans.Add(nums1[i]);
            i++;
        }

        while(j < nums2.Length){
            ans.Add(nums2[j]);
            j++;
        }

        return ans.ToArray();
    }
}