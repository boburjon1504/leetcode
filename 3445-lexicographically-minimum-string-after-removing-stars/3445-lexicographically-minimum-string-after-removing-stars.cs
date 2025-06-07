using System.Text.Json;
public class Solution {
    public string ClearStars(string s) {
        var list = s.ToArray();
        Console.WriteLine(s);
        var priority = new PriorityQueue<int, int>();

        var dc = new Dictionary<int, IList<int>>();

        for(var i = 0; i < s.Length; i++){
            var c = s[i];
            if(c == '*'){
                var smal = priority.Peek();
                var ids = dc[smal];
                var count = ids.Count;
                var id = ids[count - 1];

                if(count == 1){
                    priority.Dequeue();
                    dc.Remove(smal);
                }else{
                    ids.RemoveAt(count - 1);
                }

                list[id] = '*';

            }else{
                
                if(!dc.ContainsKey(c)){
                    priority.Enqueue(c, c);
                    dc[c] = new List<int>();
                }

                dc[c].Add(i);
            }
        }

        return string.Join("",list.Where(c => c!='*'));

    }
}