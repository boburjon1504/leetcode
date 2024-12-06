using System.Collections.Immutable;

public class SeatManager {
    private SortedSet<int> seats = new SortedSet<int>();
    public SeatManager(int n) {
        for(var i = 1; i <= n; i++){
            seats.Add(i);
        }
    }
    
    public int Reserve() {
        var seat = seats.First();
        seats.Remove(seat);

        return seat;
    }
    
    public void Unreserve(int seatNumber) {
        seats.Add(seatNumber);
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */