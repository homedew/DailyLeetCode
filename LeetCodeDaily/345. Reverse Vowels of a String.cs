// Given a string s, reverse only all the vowels in the string and return it.

// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

// Example 1:

// Input: s = "hello"
// Output: "holle"
// Example 2:

// Input: s = "leetcode"
// Output: "leotcede"

public class Solution {
    public string ReverseVowels(string s) {
        string vowels  = "aeiouAEIOU";  
        int i = 0;
        int j = s.Length - 1;
        StringBuilder sb = new StringBuilder(s);
        char[] arrayS = s.ToCharArray();

        while( i < j)
        {
            if(vowels.Contains(arrayS[i]))
            {
                if(vowels.Contains(arrayS[j]))
                {
                    char temp = sb[i];
                    sb[i] = sb[j];
                    sb[j] = temp;
                    i++;
                    j--;
                } else {
                    j--;
                }
            } else {
                i++;
            }
        }

        return sb.ToString();
    }
}