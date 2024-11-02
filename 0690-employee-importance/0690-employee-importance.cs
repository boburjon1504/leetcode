/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    public int GetImportance(IList<Employee> employees, int id) {
        var parentChild = new Dictionary<int, IList<int>>();
        var employeeImportance = new Dictionary<int, int>();
        foreach(var e in employees){
            parentChild[e.id] = e.subordinates;
            employeeImportance[e.id] = e.importance;
        }
        if(!parentChild.ContainsKey(id)){
            return 0;
        }

        var totalImportance = 0;
        var queue = new Queue<int>();
        queue.Enqueue(id);

        while(queue.Count > 0){
            var size = queue.Count;

            for(var i = 0; i < size; i++){
                var employeeId = queue.Dequeue();
                totalImportance += employeeImportance[employeeId];

                foreach(var child in parentChild[employeeId]){
                    queue.Enqueue(child);
                }
            }
        }
        
        return totalImportance;
    }
}