public class TrieNode{
    public Dictionary<char, TrieNode> Children { get; } = new();
    public bool IsEndOfTheWord { get; set; }
    public int Count = 0;
}
public class Solution {
    public int[] SumPrefixScores(string[] words) {
        var root = new TrieNode();

        foreach(var word in words){
            Insert(root, word);
        }
        var ans = new int[words.Length];

        for(var i = 0; i < words.Length; i++){
            ans[i] = GetSum(root, words[i]);
        }

        return ans;
    }
    private int GetSum(TrieNode root, string word){
        var sm = 0;
        foreach(var ch in word){
            root = root.Children[ch];
            sm += root.Count;
        }

        return sm;
    }
    private void Insert(TrieNode root, string word){
        foreach(var ch in word){
            if(!root.Children.ContainsKey(ch)){
                root.Children[ch] = new TrieNode();
            }
            root = root.Children[ch];
            root.Count++;
        }

        root.IsEndOfTheWord = true;
    }
}