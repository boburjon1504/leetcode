using System.Text.Json;

public class LUPrefix {
    private int[] arr;
    public LUPrefix(int n) {
        arr = new int[n];
    }
    
    public void Upload(int video) {
        arr[video - 1] = 1;
    }
    
    public int Longest() {
        var index = Array.IndexOf(arr, 0);

        if(index < 0) return arr.Length;

        return index;
    }
}

/**
 * Your LUPrefix object will be instantiated and called as such:
 * LUPrefix obj = new LUPrefix(n);
 * obj.Upload(video);
 * int param_2 = obj.Longest();
 */