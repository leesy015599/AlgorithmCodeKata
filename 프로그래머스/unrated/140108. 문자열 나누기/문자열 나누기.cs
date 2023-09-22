using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        int index = 0;
        while (index < s.Length)
        {
            char x = s[index];
            int xCount = 0;
            int yCount = 0;
            for (int i = index; i < s.Length; i++)
            {
                if (s[i] == x)
                    ++xCount;
                else
                    ++yCount;
                if (xCount == yCount)
                {
                    index = i;
                    break;
                }
                if (i + 1 == s.Length)
                {
                    index = i;
                    break;
                }
            }
            ++answer;
            ++index;
        }
        
        return answer;
    }
}