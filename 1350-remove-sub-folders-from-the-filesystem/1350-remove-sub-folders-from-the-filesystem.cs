public class TrieNode{
    public Dictionary<string, TrieNode> Children { get; } = new();
    public bool IsEndOfTheWord { get; set; }
}

public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        var root = new TrieNode();
        var res = new List<string>();
        foreach(var fl in folder.OrderBy(x => x.Length)){
            if(InsertIfNotExist(root, fl)){
                res.Add(fl);
            }
        }

        return res;

    }
    public bool InsertIfNotExist(TrieNode root, string folder){
        foreach(var fl in folder.Split('/')){
            if(!root.Children.ContainsKey(fl)){
                root.Children[fl] = new TrieNode();
            }
            root = root.Children[fl];

            if(root.IsEndOfTheWord){
                return false;
            }
        }

        root.IsEndOfTheWord = true;

        return true;
    }
}