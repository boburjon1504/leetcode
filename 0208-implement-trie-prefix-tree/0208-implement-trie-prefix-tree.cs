public class TrieNode{
    public Dictionary<char, TrieNode> Children { get; } = new();
    public bool IsEndOfTheWord;
}

public class Trie {
    private TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        var cur = root;

        foreach(var i in word){
            if(!cur.Children.ContainsKey(i)){
                cur.Children[i] = new TrieNode();
            }
            cur = cur.Children[i];

        }
        cur.IsEndOfTheWord = true;
    }
    
    public bool Search(string word) {
        var cur = root;

        foreach(var i in word){
            if(!cur.Children.ContainsKey(i)){
                return false;
            }
            cur = cur.Children[i];
        }

        return cur.IsEndOfTheWord;
    }
    
    public bool StartsWith(string prefix) {
        var cur = root;

        foreach(var i in prefix){
            if(!cur.Children.ContainsKey(i)){
                return false;
            }

            cur = cur.Children[i];
        }

        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */