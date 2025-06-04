using System.Text.Json;
public class Solution {
    public void DuplicateZeros(int[] arr) {
        for(var i = 0; i < arr.Length - 1; i++){
            if (arr[i] == 0){
                i++;
                Shift(arr, i);
            }
        }
    }
    
    private void Shift(int[] arr, int start){
        var prev = arr[start];
        for(var i = start + 1; i < arr.Length; i++){
            var curr = arr[i];
            arr[i] = prev;
            prev = curr;
        }
        
        arr[start] = 0;
    }
}