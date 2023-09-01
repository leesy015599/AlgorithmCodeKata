using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        int tLen = t.Length;
        int pLen = p.Length;
        for (int i = 0; i < tLen - pLen + 1; i++)
        {
            double part = 0;
            for (int j = 0; j < pLen; j++)
                part = part * (double)10 + double.Parse(Char.ToString(t[i + j]));
            answer = (part <= double.Parse(p)) ? answer + 1 : answer;
        }
        
        return answer;
    }
}