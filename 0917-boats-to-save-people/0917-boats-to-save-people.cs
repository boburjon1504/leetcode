public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int counter = 0, l = 0, r = people.Length - 1;
        
        while (l <= r) {
            if (people[l] + people[r] <= limit) {
                l++;
            }
            r--;
            counter++;
        }
        
        return counter;
    }
}