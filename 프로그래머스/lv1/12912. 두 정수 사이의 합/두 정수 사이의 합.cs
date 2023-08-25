public class Solution {
    public long solution(int a, int b) {
        if (a == b)
            return a;
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        long sum = 0;
        for (int i = a; i < b + 1; i++)
        {
            sum += (long)i;
        }
        
        long answer = sum;
        return answer;
    }
}