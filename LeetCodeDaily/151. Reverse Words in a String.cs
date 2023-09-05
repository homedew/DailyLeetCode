// Given an input string s, reverse the order of the words.

// A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

// Return a string of the words in reverse order concatenated by a single space.

// Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

 

// Example 1:

// Input: s = "the sky is blue"
// Output: "blue is sky the"
// Example 2:

// Input: s = "  hello world  "
// Output: "world hello"
// Explanation: Your reversed string should not contain leading or trailing spaces.
// Example 3:

// Input: s = "a good   example"
// Output: "example good a"
// Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

public class Solution {
    public string ReverseWords(string s) {
        StringBuilder sb = new StringBuilder();
        char[] arrayS = s.ToCharArray();
        int left = 0;
        int right = 0;
        while(left < s.Length)
        {
            while(left < s.Length && arrayS[left] == ' ') left++;

            right = left + 1;
            if(right > s.Length) break;
            while( right < s.Length  && arrayS[right] != ' ') right++;

            string subWord = s.Substring(left, right - left);

            if(sb.Length == 0)
            {
                sb.Append(subWord);
            } else {
                sb.Insert(0, subWord + " ");
            }

            left = right++;

        }

        return sb.ToString();
    }
}