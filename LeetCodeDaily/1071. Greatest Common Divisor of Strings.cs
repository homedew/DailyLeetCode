// For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).

// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

 

// Example 1:

// Input: str1 = "ABCABC", str2 = "ABC"
// Output: "ABC"
// Example 2:

// Input: str1 = "ABABAB", str2 = "ABAB"
// Output: "AB"
// Example 3:

// Input: str1 = "LEET", str2 = "CODE"
// Output: ""

public class Solution {

    private int GcdOfInt(int l1, int l2)
    {
        if(l2 == 0) return l1;

        return GcdOfInt(l2, l1 % l2);
    }
    public string GcdOfStrings(string str1, string str2) {
        if(str1 + str2  != str2 + str1) return "";

        string result = str1.Substring(0, GcdOfInt(str1.Length, str2.Length));
        
        return result;
    }
}

/*
6 % 3 = 0

6 % 4 = 2
4 % 2 = 0

*/