class Solution {
    public int romanToInt(String s) {
        HashMap<String, Integer> hash = new HashMap<String, Integer>()
        {{
            put("I", 1);
            put("V", 5);
            put("X", 10);
            put("L", 50);
            put("C", 100);
            put("D", 500);
            put("M", 1000);
        }};

      int prev = 0 ;
      int res=  0;

      for(int i = s.length(); i>= 0; i--)
        {
            int current = hash.get(s.substring(i, i + 1));
            if(current > prev) {
              res-= current;
            } else{
              res+= current;
            }

          prev =  hash.get(s.substring(i, i + 1 ));
        }

      return res;
    }
}
