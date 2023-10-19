public class Solution {
    public bool IsPalindrome(int x) {
        int carry = 0;
        int c = x;

        while(c > 0)
        {
            carry = carry * 10 + c % 10;
            c/= 10;
        }

        return carry == x;
    }
}