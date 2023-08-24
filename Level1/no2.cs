public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        
        int index = 0;
        while (index < arr.Length)
        {
            answer += arr[index++];
        }
        answer /= index;
        
        return answer;
    }
}
