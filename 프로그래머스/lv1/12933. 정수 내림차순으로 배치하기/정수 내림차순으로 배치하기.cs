using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        List<int> list = new List<int>();
        while (n != 0)
        {
            list.Add((int)(n % 10));
            n /= 10;
        }
        long answer = 0;
        
        for (int i = 9; i >= 0; i--)
        {
            foreach (int elem in list)
            {
                if (elem == i)
                {
                    answer *= 10;
                    answer += elem;
                }
            }
        }
        
        return answer;
    }
}