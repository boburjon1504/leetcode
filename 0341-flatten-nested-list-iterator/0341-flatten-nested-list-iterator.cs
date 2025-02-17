/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Node{
    public int val;
    public Node next;

    public Node(int v) => val = v;
}
public class NestedIterator {
    private Node head = null;
    public NestedIterator(IList<NestedInteger> nestedList) {
        var temp = head;
        var res = new List<int>();

        GetList(nestedList,res);
        Console.WriteLine(string.Join(" ", res));
        foreach(var n in res){
            if(head is null){
                head = new Node(n);
                temp = head;
            }else{
                temp.next = new Node(n);
                temp = temp.next;
            }
        }
        
    }

    private void GetList(IList<NestedInteger> ls, IList<int> res){
        foreach(var n in ls){
            if(n.IsInteger()){
                var a = n.GetInteger();
                res.Add(a);
            }else{
                var list = n.GetList();
                GetList(list, res);
            }
        }
    }

    public bool HasNext() {
        return head is not null;
    }

    public int Next() {
        var val = head.val;
        head = head.next;
        return val;
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */