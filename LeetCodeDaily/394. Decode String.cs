// https://leetcode.com/problems/decode-string/

public class Solution {
    public string DecodeString(string s) {
        Stack<char> charStack = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ']')
            {
                List<char> charList = new List<char>();
                while( charStack.Peek() != '[')
                {
                    charList.Add(charStack.Pop());
                }

                int k = 0;
                int baseNumber = 1;
                charStack.Pop();
                while( charStack.Any() && char.IsDigit(charStack.Peek()))
                {
                    k = k + (charStack.Pop() - '0') * baseNumber;
                    baseNumber *= 10;
                }

                while(k !=0)
                {
                    for(int j = charList.Count() - 1; j >=0; j--)
                    {
                        charStack.Push(charList[j]);
                    }

                    k--;
                }
            }
            else {
                charStack.Push(s[i]);
            }
        }

        StringBuilder sb = new StringBuilder();
        while(charStack.Any())
        {
            sb.Append(charStack.Pop());
        }
        char[] result = sb.ToString().ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}