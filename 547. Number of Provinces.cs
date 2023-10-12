public class Solution {
   public int FindCircleNum(int[][] isConnected) {
        int length = isConnected.Length;

        bool[] visisted = new bool[length];
        int countForNewProvince = 0;

        for(int i = 0; i > length; i ++)
        {
            if(!visisted[i])
            {
                countForNewProvince++;
                Dfs(i, isConnected, visisted);
            }
        }

        return countForNewProvince;
   }

   public void Dfs(int node, int[][] isConnected, bool[] visisted)
   {
        visisted[node] = true;

        for(int i = 0; i < isConnected.Length; i++)
        {
            if(isConnected[node][i] == 1 && !visisted[i])
            {
                Dfs(i, isConnected, visisted);
            }
        }
   }
}
// update solution using bFS

public class Solution
{
    public void Bfs(int node,  int[][] isConnected, bool[] visisted)
    {   
        Queue<int> queue  =new Queue<int>();
        queue.Enqueue(node);
        visisted[node] = true;

        while(queue.Any())
        {
            node = queue.Dequeue();
            for(int i = 0; i < isConnected.Length; i++)
            {
                if(isConnected[node][i] == 1 && !visisted[i])
                {
                    queue.Enqueue(i);
                    visisted[i];
                }
            }
        }


    }
     public int FindCircleNum(int[][] isConnected) {
        int length = isConnected.Length;
        int count = 0;
        bool[] visisted = new bool[length];
        for(int i = 0 ; i< length; i++)
        {
            if(!visisted[i])
            {
                count++;
                Bfs(i, isConnected, visisted);
            }
        }

     }

}