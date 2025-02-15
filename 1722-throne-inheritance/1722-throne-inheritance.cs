public class Node{
    public string Name { get; set; }
    public bool IsAlive { get; set; }
    public IList<Node> Children { get; set; }
    public Node(string name){
        Name = name;
        Children = new List<Node>();
        IsAlive = true;
    }
}

public class ThroneInheritance {
    private Dictionary<string, Node> tree;
    private Node King;
    public ThroneInheritance(string kingName) {
        tree = new Dictionary<string, Node>();
        King = new Node(kingName);
        tree[kingName] = King;

    }
    
    private void Birth(string name){
        tree[name] = new Node(name);
    }
    private void AddToParent(string parent, string child){
        tree[parent].Children.Add(tree[child]);
    }
    public void Birth(string parentName, string childName) {
        Birth(childName);
        AddToParent(parentName, childName);
    }
    
    public void Death(string name) {
        tree[name].IsAlive = false;
    }
    
    public IList<string> GetInheritanceOrder() {
        var all = new List<string>();
        GetInheritanceOrder(King, all);

        return all;
    }

    private void GetInheritanceOrder(Node node,IList<string> all){
        if(node.IsAlive){
            all.Add(node.Name);
        }
        if(node.Children.Count == 0){
            return;
        }
        foreach(var child in node.Children){
            GetInheritanceOrder(child, all);
        }
    }
}

/**
 * Your ThroneInheritance object will be instantiated and called as such:
 * ThroneInheritance obj = new ThroneInheritance(kingName);
 * obj.Birth(parentName,childName);
 * obj.Death(name);
 * IList<string> param_3 = obj.GetInheritanceOrder();
 */