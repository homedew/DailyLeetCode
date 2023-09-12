// Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

// Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

 

// Example 1:

// Input: s = "abciiidef", k = 3
// Output: 3
// Explanation: The substring "iii" contains 3 vowel letters.
// Example 2:

// Input: s = "aeiou", k = 2
// Output: 2
// Explanation: Any substring of length 2 contains 2 vowels.
// Example 3:

// Input: s = "leetcode", k = 3
// Output: 2
// Explanation: "lee", "eet" and "ode" contain 2 vowels.
public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> vowels = new HashSet<char>(){'a', 'e', 'i', 'o', 'u'};
        int count = 0;

        //init window
        for(int i = 0; i< k; i++)
        {
            count+= vowels.Contains(s[i]) ? 1: 0;
        }
        if(count == k) return count;
        
        int result = count;
        // slide the window
        for(int i = k ;i < s.Length;i ++)
        {
            count+= vowels.Contains(s[i]) ?  1: 0;
            count-= vowels.Contains(s[i - k]) ? 1: 0;
            result = Math.Max(result, count);

        }

        return result;
    }
}