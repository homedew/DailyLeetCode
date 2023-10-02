//https://leetcode.com/problems/number-of-recent-calls
public class RecentCounter {

    private Queue<int> queue;
    public RecentCounter() {
        queue = new Queue<int>();
    }
    
    public int Ping(int t) {
        queue.Enqueue(t);
        while(queue.Peek() < t - 3000)
        {
            queue.Dequeue();
        }

        return queue.Count();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */