public class Solution {
    public string LongestPalindrome(string s) {
        int max = 0;
        int start = 0;

        for(int i = 0; i < s.Length; i++)
        {
            int left =i, right = i;
            while(right < s.Length - 1&& s[right] == s[right + 1]) right++;

            while(left > 0 && right < s.Length - 1 && s[left - 1] == s[right + 1]) 
            {
                left --;
                right ++;
            }

            if(right - left + 1 > max)
            {
                max = right - left + 1;
                start = left;
            }

            return s.Substring(start, max);
        }
    }
}