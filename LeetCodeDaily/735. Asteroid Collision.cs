// https://leetcode.com/problems/asteroid-collision
public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> s = new Stack<int>();
        foreach(int a in asteroids)
        {
           bool flag = true;
           while(s.Any() && (s.Peek() > 0 && a < 0))
           {
               if(Math.Abs(s.Peek()) < Math.Abs(a))
               {
                   s.Pop(); 
                   continue;
               } else if(Math.Abs(s.Peek()) == Math.Abs(a)){
                   s.Pop();
               }

               flag = false;
               break;
           }

           if(flag)
           {
               s.Push(a);
           }
        }

        
        return s.Reverse().ToArray();
    }
}

// 2 10 - 5
