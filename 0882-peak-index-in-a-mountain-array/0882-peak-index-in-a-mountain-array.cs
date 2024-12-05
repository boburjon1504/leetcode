public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        var mx = 0;
        for(var i = 0; i < arr.Length; i++){
            if(arr[mx] < arr[i]){
                mx = i;
            }
        }

        return mx;
    }
}