public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int tempX = x;
        
        while (tempX != 0)
        {
            sum += tempX % 10;
            tempX /= 10;
        }
        
        bool answer = true;
        if (x % sum != 0)
            answer = false;
        
        return answer;
    }
}