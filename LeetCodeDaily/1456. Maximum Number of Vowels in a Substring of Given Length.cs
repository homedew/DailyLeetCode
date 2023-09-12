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
        string vowels = "aeiou";
        int res =0;
        int count =0;
        int i =0;
        int j = 0;
        while(i + k  <= s.Length)
        {
            j = i;
            while( i  <j  + k )
            {
                if(vowels.Contains(s[i]))
                {
                    count += 1;
                    i++;
                    if(i > s.Length)
                    {
                        break;
                    }
                } else {
                    i++;
                }

            }
            res = Math.Max(res, count);
            count = 0;
            i = j + 1;
        }

        return res;
    }
}