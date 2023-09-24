// Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) such that row ri and column cj are equal.

// A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).

 

// Example 1:


// Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
// Output: 1
// Explanation: There is 1 equal row and column pair:
// - (Row 2, Column 1): [2,7,7]
// Example 2:


// Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
// Output: 3
// Explanation: There are 3 equal row and column pairs:
// - (Row 0, Column 0): [3,1,2,2]
// - (Row 2, Column 2): [2,4,2,2]
// - (Row 3, Column 2): [2,4,2,2]

public class Solution {
    public int EqualPairs(int[][] grid) {
        int match = 0;
        bool isMatch = true;
        for(int r = 0; r < grid.Length; r++)
        {
            for(int c = 0; c < grid.Length; c++)
            {
                isMatch = true;
                for(int i = 0; i< grid.Length; i++)
                {
                    if(grid[r][i] != grid[i][c])
                    {
                        isMatch = false;
                        break;
                    }

                }

                match += isMatch ? 1 : 0;
            }
        }

        return match;
    }
}

/*
    3 1 2 2



*/