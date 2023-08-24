public class Solution {
    public int[] solution(long n) {
        int size = 0;
        long tempN = n;
        while (tempN != 0)
        {
            tempN /= 10;
            size++;
        }        
        
        int[] answer = new int[size];
        int index = 0;
        while (index < size)
        {
            answer[index++] = (int)(n % 10);
            n /= 10;
        }
                
        return answer;
    }
}
