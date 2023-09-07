using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            int j = i - 1;
            for (j = i - 1; j >= -1; j--)
            {
                if (j == -1)
                    break;
                if (s[j] == s[i])
                    break;
            }
            answer[i] = (j == -1) ? -1 : i - j;
        }
        return answer;
    }
}