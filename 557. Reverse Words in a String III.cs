// https://leetcode.com/problems/reverse-words-in-a-string-iii/

public class Solution {

    public string ReverseWords(string s) {
        int left = 0;
        int right = 0;
        StringBuilder sb = new StringBuilder();

        while(left < s.Length)
        {
            while(left <s.Length && s[left] == ' ') left++;
            while(right< s.Length && s[right] != ' ') right++;
            if(right > s.Length) break;
            String word = s.Substring(left, right - left);
            StringBuilder reverseWord = new StringBuilder();

            for(int i = word.Length - 1; i>= 0 ; i--)
            {
                reverseWord.Append(word[i]);
            }
            sb.Append(reverseWord + " ");

            left = right++;
        }

        return sb.ToString().Substring(0, sb.Length - 1);
    }
}