using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;
        int l = (a > b) ? a : b;
        int s = (a > b) ? b : a;
        while (n / 2 != 1)
        {
            if (l % 2 == 0 && l - s == 1)
                break;
            n /= 2;
            l = (l + 1) / 2;
            s = (s + 1) / 2;
            answer++;
        }
        return answer;
    }
    
    // private int NextRound(int num)
    // {
    //     if (num % 2 == 0)
    //         return num / 2;
    //     return (num + 1) / 2;
    // }
}