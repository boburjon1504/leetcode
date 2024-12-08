public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        var mx = 0;
        for(var i = 0; i < nums1.Length; i++){
            int l = 0, r = nums2.Length - 1;

            while(l < r){
                var md = (l + r) / 2;

                if(nums2[md] >= nums1[i]){
                    l = md + 1;
                }else {
                    r = md - 1;
                }
            }
            Console.WriteLine($"{i}  {l}");
            var distance = l - i;
            if(l >= nums2.Length && distance > mx){
                mx = distance;
            }else
            if(l == i && nums1[i] <= nums2[l] && mx < distance){
                mx = distance;
            }else if(l > i && l < nums2.Length && nums1[i] <= nums2[l] && mx < distance){
                mx = distance;
            }else if(l > i && l < nums2.Length && nums2[l] < nums1[i] && l - 1 - i > mx){
                mx = l - 1 - i;
            }
        }

        return mx;
    }
}