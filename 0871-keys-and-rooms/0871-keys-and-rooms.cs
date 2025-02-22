
public class Solution {
    private IList<IList<int>> _rooms;
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        _rooms = rooms;
        var set = new HashSet<int>();
        GetKeys(0, set);
        Console.WriteLine(string.Join(" ", set));
        return rooms.Count == set.Count;
    }
    private void GetKeys(int room, HashSet<int> keys){
        if(keys.Contains(room)) return;
        
        keys.Add(room);

        foreach(var key in _rooms[room]){
            GetKeys(key, keys);
        }
    }
}