using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        int sign;
        for (int i = 0; i < signs.Length; i++)
        {
            sign = signs[i] ? 1 : -1;
            answer += sign * absolutes[i];
        }
        return answer;
    }
}