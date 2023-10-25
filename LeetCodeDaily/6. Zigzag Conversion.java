//6. Zigzag Conversion

class Solution {
    public String convert(String s, int numRows) {
      StringBuilder[] sb = new StringBuilder[numRows];
      int length = sb.length();
      char[] charArray = s.toCharArray();

      for(int i = 0 ; i < numRows; i++)
        {
            sb[i] = new StringBuilder();
        }

      int i = 0;

      while( i < length)
        {
            for(int idx = 0; idx < numRows && i < length; idx++)
              {
                  sb[idx].append(charArray[i++]);
              }

          for(int idx  = numRows - 2; idx >= 1 && i < length; idx--)
            {
                  sb[idx].append(charArray[i++]);
            }
        }

      for(int idx = 1; idx < sb.length; idx++)
        {
            sb[0].append(sb[idx]);
        }

      return sb[0].toString();
    }
}
