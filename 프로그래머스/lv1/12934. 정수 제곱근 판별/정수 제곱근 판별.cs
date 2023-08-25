using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        for (long i = 1; i < n / 2 + 2; i++)
        {
            if (n / i == i && n % i == 0)
            {
                answer = i;
                break ;
            }
        }
        if (answer == 0)
            return -1;
        answer = (answer + 1) * (answer + 1);
        return answer;
    }
}