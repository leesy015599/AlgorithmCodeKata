using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        int result;
        if (IsSquareRoot(yellow, out result))
        {
            answer[0] = result + 2;
            answer[1] = answer[0];
            return answer;
        }
        
        while (true)
        {
            if (yellow % result == 0)
            {
                answer[0] = (yellow / result + 2 > result + 2) ? yellow/result+2 : result + 2;
                answer[1] = (yellow / result + 2 > result + 2) ? result + 2 : yellow/result+2;
                if (brown == 2 * answer[0] + 2 * answer[1] - 4)
                    break;
            }
            --result;
        }
        
        return answer;
    }
    
    private bool IsSquareRoot(int yellow, out int result)
    {
        int i;
        for (i = 1; i * i <= yellow; i++)
        {
            if (i == yellow / i && yellow % i == 0)
            {
                result = i;
                return true;
            }
        }
        result = i;
        return false;
    }
}