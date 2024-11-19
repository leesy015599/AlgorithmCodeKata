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
            for (int stackIdx = 0; stackIdx < s.Length; stackIdx++)
            {
                int curIdx = (firstIdx + stackIdx) % s.Length;
                int braceIdx = close.IndexOf(s[curIdx]);
                if (stack.Count != 0 && braceIdx != -1 && braceIdx == open.IndexOf(stack.Peek()))
                    stack.Pop();
                else
                    stack.Push(s[curIdx]);
            }
            if (stack.Count == 0)
                answer++;
        }
        return answer;
    }
}