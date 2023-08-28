using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = (long)money;
        for (int i = 1; i < count + 1; i++)
        {
            answer -= (long)price * (long)i;
        }
        
        if (answer >= 0)
            return 0;
        return answer * (long)(-1);
    }
}