// Two strings are considered close if you can attain one from the other using the following operations:

// Operation 1: Swap any two existing characters.
// For example, abcde -> aecdb
// Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
// For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
// You can use the operations on either string as many times as necessary.

// Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.

 

// Example 1:

// Input: word1 = "abc", word2 = "bca"
// Output: true
// Explanation: You can attain word2 from word1 in 2 operations.
// Apply Operation 1: "abc" -> "acb"
// Apply Operation 1: "acb" -> "bca"
// Example 2:

// Input: word1 = "a", word2 = "aa"
// Output: false
// Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
// Example 3:

// Input: word1 = "cabbba", word2 = "abbccc"
// Output: true
// Explanation: You can attain word2 from word1 in 3 operations.
// Apply Operation 1: "cabbba" -> "caabbb"
// Apply Operation 2: "caabbb" -> "baaccc"
// Apply Operation 2: "baaccc" -> "abbccc"


public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }
        
        int[] word1Map = new int[26];

        int[] word2Map = new int[26];

        foreach(char c in word1)
        {
            word1Map[c - 'a']++;
        }

        foreach(char c in word2)
        {
            word2Map[c - 'a']++;
        }

        for(int i = 0;i < 26 ; i++)
        {
            if(word1Map[i] == 0 && word2Map[i] > 0  || word2Map[i] == 0 && word1Map[i] > 0 ) return false;
        }

        Array.Sort(word1Map);
        Array.Sort(word2Map);

        for(int i  = 0 ; i< word1Map.Length; i ++)
        {
            if(word1Map[i] != word2Map[i]) return false;
        }

        return true;
        
    }
}

