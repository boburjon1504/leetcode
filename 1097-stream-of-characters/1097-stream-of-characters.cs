using System.Text;

public class TrieNode{
    public Dictionary<char, TrieNode> Children { get; } = new();
    public bool IsEndOfTheWord { get; set; }
}

public class StreamChecker {
    private int length = 0;
    private IList<char> stream = new List<char>();
    private TrieNode root;
    public StreamChecker(string[] words) {
        root = new TrieNode();
        foreach(var word in words){
            Insert(root, word);
        }
    }

    private void Insert(TrieNode root, string word){
        for(var i = word.Length - 1; i >= 0; i--){
            if(!root.Children.ContainsKey(word[i])){
                root.Children[word[i]] = new TrieNode();
            }
            root = root.Children[word[i]];
        }

        root.IsEndOfTheWord = true;
    }
    public bool Query(char letter) {
        stream.Add(letter);
        var temp = root;
        for(var i = stream.Count - 1; i >= 0; i--){
            if(!temp.Children.ContainsKey(stream[i])){
                return false;
            }
            temp = temp.Children[stream[i]];

            if(temp.IsEndOfTheWord){
                return true;
            }
        }
        return false;
    }
}

/**
 * Your StreamChecker object will be instantiated and called as such:
 * StreamChecker obj = new StreamChecker(words);
 * bool param_1 = obj.Query(letter);
 */