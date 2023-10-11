public class Solution {
    bool[] visisted;
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        visisted = new bool[rooms.Count];
        Dfs(0, rooms);

        return visisted.All(v => v);

    }

    public void Dfs(int room, IList<IList<int>> rooms)
    {
        if(visisted[room]) return;

        visisted[room] = true;
        int i= 0;
        foreach(int key in rooms[room])
        {
            i++;
            Console.WriteLine(i + ", " + key);
            Dfs(key, rooms);
        }
    }
}


// [[1,3],[3,0,1],[2],[0]]

public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] visisted = new bool[rooms.Count];   
        visisted[0] = true;

        Stack<int> room = new Stack<int>();
        room.Push(0);

        while(room.Any())
        {
            int key = room.Pop();
           
            foreach(int k in rooms[key])
            {
                if(!visisted[k])
                {
                    visisted[k] = true;
                    room.Push(k);
                }
            }
        }
        return visisted.All(v=> v);
        
    }
}