using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        string open = "([{";
        string close = ")]}";
        int answer = 0;
        for (int firstIdx = 0; firstIdx < s.Length; firstIdx++)
        {
            Stack<char> stack = new Stack<char>();
            for (int addIdx = 0; addIdx < s.Length; addIdx++)
            {
                int curIdx = (firstIdx + addIdx) % s.Length;
                char curChar = s[curIdx];
                if (stack.Count != 0 && close.IndexOf(curChar) == open.IndexOf(stack.Peek()) && close.IndexOf(curChar) != -1)
                    stack.Pop();
                else
                    stack.Push(curChar);
            }
            if (stack.Count == 0)
                answer++;
        }
        return answer;
    }
}