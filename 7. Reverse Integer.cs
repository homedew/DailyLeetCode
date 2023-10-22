public class Solution {
    public int Reverse(int x) {
        int res = 0;

        while( x !=0)
        {
            int remainder = x % 10;
            int temp = res * 10 + remainder;

            if((temp - remainder) / 10 != res) return 0;
            res = temp;
            x/= 10;
        }

        return res;
    }
}