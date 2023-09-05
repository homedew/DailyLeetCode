// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

// Return the merged string.

 

// Example 1:

// Input: word1 = "abc", word2 = "pqr"
// Output: "apbqcr"
// Explanation: The merged string will be merged as so:
// word1:  a   b   c
// word2:    p   q   r
// merged: a p b q c r
// Example 2:

// Input: word1 = "ab", word2 = "pqrs"
// Output: "apbqrs"
// Explanation: Notice that as word2 is longer, "rs" is appended to the end.
// word1:  a   b 
// word2:    p   q   r   s
// merged: a p b q   r   s
// Example 3:

// Input: word1 = "abcd", word2 = "pq"
// Output: "apbqcd"
// Explanation: Notice that as word1 is longer, "cd" is appended to the end.
// word1:  a   b   c   d
// word2:    p   q 
// merged: a p b q c   d

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int maxLength = Math.Max(word1.Length, word2.Length);
        int i = 0;
        int word1Length = word1.Length;
        int word2Length = word2.Length;

        StringBuilder sb = new StringBuilder();

        while(i < maxLength)
        {
            if(i < word1Length)
            {
                sb.Append(word1[i]);
            }

            if(i < word2Length)
            {
                sb.Append(word2[i]);
            }

            i++;
        }

        return sb.ToString();
    }
}