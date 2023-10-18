public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0;
        int i =0, j =0;
        HashSet<int> hs = new HashSet<int>();
        while(j < s.Length)
        {
            if(hs.Contains(s[j]))
            {
                hs.Remove(s[i]);
                i++;
            } else {
                hs.Add(s[j]);

                ans = Math.Max(ans, j - i + 1);
                j++;
            }
        }

        return ans;
    }
}