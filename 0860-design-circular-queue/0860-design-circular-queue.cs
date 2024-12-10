public class MyCircularQueue {
    int curSize = 0, size;
    List<int> data;
    public MyCircularQueue(int k) {
        size = k;
        data = new List<int>();
    }
    
    public bool EnQueue(int value) {
        if(curSize == size) return false;
        data.Add(value);
        curSize++;
        return true;
    }
    
    public bool DeQueue() {
        if(curSize == 0) return false;
        data.RemoveAt(0);
        curSize--;
        return  true;
    }
    
    public int Front() {
        if(curSize == 0) return -1;
        return data[0];
    }
    
    public int Rear() {
        if(curSize == 0) return -1;
        return data[data.Count-1];
    }
    
    public bool IsEmpty() {
        if(curSize == 0) return true;
        return false;
    }
    
    public bool IsFull() {
        if(size == curSize) return true;
        return false;
    }
}