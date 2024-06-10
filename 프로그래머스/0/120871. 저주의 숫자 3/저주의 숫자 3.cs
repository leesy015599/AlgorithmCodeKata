using System;

public class Solution {
    public int solution(int n) {
        int answer = n;;
        for (int i = 1; i <= answer; i++)
        {
            if (i % 3 == 0 || i % 10 == 3 || i % 100 / 10 == 3)
                answer++;
        }
        return answer;
    }
}