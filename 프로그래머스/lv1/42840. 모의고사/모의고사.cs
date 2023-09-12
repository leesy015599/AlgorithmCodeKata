using System;

public class Solution {
    public int[] solution(int[] answers) {
        int[] supo1 = new int[5]{1, 2, 3, 4, 5};
        int[] supo2 = new int[8]{2, 1, 2, 3, 2, 4, 2, 5};
        int[] supo3 = new int[10]{3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int[] score = new int[3];
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (supo1[i % 5] == answers[i])
                score[0] += 1;
            if (supo2[i % 8] == answers[i])
                score[1] += 1;
            if (supo3[i % 10] == answers[i])
                score[2] += 1;
        }
        int[] tempScore = new int[3]{score[0], score[1], score[2]};
        Array.Sort(score);
        int topScore = score[2];        
        int topScoreCount = 0;
        for (int i = 0; i < 3; i++)
            topScoreCount += (score[i] == topScore) ? 1 : 0;
        int[] answer = new int[topScoreCount];
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            if (tempScore[i] == topScore)
            {
                answer[index] = i + 1;
                index++;
            }
        }
        return answer;
    }
}