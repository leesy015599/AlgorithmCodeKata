using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
                
        while (answer++ < n)
        {
            if (n % answer == 1)
                break ;
        }
        
        return answer;
    }
}
