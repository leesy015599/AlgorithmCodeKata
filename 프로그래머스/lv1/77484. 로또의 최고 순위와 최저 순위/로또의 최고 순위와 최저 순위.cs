using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        Array.Sort(lottos);
        Array.Sort(win_nums);
        
        int l = 0;
        int w = 0;
        int count = 0;
        int zero = 0;
        
        while (l < 6 && w < 6)
        {
            if (lottos[l] == 0)
                zero++;
            if (lottos[l] == win_nums[w])
            {
                count++;
                l++;
                w++;
            }
            else if (lottos[l] < win_nums[w])
                l++;
            else // lottos[i] > win_nums[w]
                w++;
        }
        
        int[] answer = new int[2] {7 - count - zero, 7 - count};
        if (answer[0] == 7)
            answer[0] = 6;
        if (answer[1] == 7)
            answer[1] = 6;
        
        return answer;
    }
}