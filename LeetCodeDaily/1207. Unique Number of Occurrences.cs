// Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

 

// Example 1:

// Input: arr = [1,2,2,1,1,3]
// Output: true
// Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
// Example 2:

// Input: arr = [1,2]
// Output: false
// Example 3:

// Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
// Output: true

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> hsArray = new Dictionary<int, int>();
        HashSet<int> hsCount = new HashSet<int>();

        foreach(int i in arr)
        {
            if(hsArray.ContainsKey(i))
            {
                hsArray[i]++;
            } else {
                hsArray.Add(i, 1);
            }

        }

        foreach(var kv in hsArray)
        {
            if(hsCount.Contains(kv.Value))
            {
                return false;
            } else {
                hsCount.Add(kv.Value);
            }

        }

        return true;

    }
}