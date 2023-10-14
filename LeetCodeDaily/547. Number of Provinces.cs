public class UnionFind 
{
    int[] parrent;
    int[] rank;

    public UnionFind(int size)
    {
        parrent = new int[size];
        for(int i = 0; i < size; i++)
        {
            parrent[i] = i;
        }

        rank = new int[size];
    }

    public int find(int x)
    {
        if(parrent[x] != x)
        {
            parrent[x] = find(parrent[x]);
        }

        return parrent[x];
    }

    public void union_set(int x, int y)
    {
        int xset = find(x), yset = find(y);
        if(xset == yset)
        {
            return;
        } else if(rank[xset] < rank[yset])
        {
            parrent[xset] = yset;
        } else if(rank[xset] > rank[yset]) {
            parrent[yset] = xset;
        } else {
            parrent[yset] = xset;
            rank[xset]++;
        }
    }
}
public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        UnionFind d = new UnionFind(n);

        int count = n;

        for(int i =  0 ; i < n; i ++) {
            for(int j = i + 1; j < n ; j ++)
            {
                if(isConnected[i][j] == 1 && d.find(i) != d.find(j))
                {
                    count--;
                    d.union_set(i, j );
                }
            }
        }

        return count;
    }
}