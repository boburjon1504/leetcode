public class Solution {
    public string CompressedString(string word) {
        StringBuilder comp = new StringBuilder();
        int n = word.Length;
        int start = 0;
        while (start < n) {
            char currentChar = word[start];
            int count = 0;
            int end = start;
            while (end < n && word[end] == currentChar && count < 9) {
                count++;
                end++;
            }
            comp.Append(count).Append(currentChar);
            start = end;
        }

        return comp.ToString();
    }
}