using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] yaksu = new int[100];
        for (int i = 2; i <= n; i++)
        {
            if (yaksu[i - 1] < 3)
            {
                for (int j = 2; i * j <= 100; j++)
                    yaksu[i * j - 1] = 3;
            }
            else
                answer++;
        }
        return answer;
    }
}