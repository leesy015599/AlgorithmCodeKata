using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        
        while (n != 0 && n >= a)
        {
            n = n - a + b;
            answer += b;
        }
        return answer;
    }
}