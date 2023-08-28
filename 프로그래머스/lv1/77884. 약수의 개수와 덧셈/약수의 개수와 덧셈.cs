using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for (int i = left; i < right + 1; i++)
        {
            if (GetDivisorCount(i) % 2 == 0)
                answer += i;
            else
                answer -= i;
        }
        return answer;
    }
    
    private int GetDivisorCount(int num)
    {
        int result = 0;
        if (num == 1)
            return 1;
        for (int i = 1; i < num + 1; i++)
        {
            if (num % i == 0)
                result++;
        }
        return result;
    }
}