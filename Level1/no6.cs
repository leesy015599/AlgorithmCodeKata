public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        int index = 0;
        while (index < n)
        {
            answer[index] = (long)x * (index + 1);
            index++;
        }
        return answer;
    }
}
