public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int divisor = 0;
        
        while (++divisor <= n)
        {
            if (n % divisor == 0)
                answer += divisor;
        }
        
        return answer;
    }
}
