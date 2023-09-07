using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        // 물 빼고 모든 음식의 개수는 짝수개여야 함
        List<char> answerList = new List<char>();
        
        for (int i = 1; i < food.Length; i++)
        {
            if (food[i] > 1)
            {
                for (int j = 1; j <= food[i] / 2; j++)
                    answerList.Add(($"{i}")[0]);
            }
        }
        answerList.Add(("0")[0]);
        for (int i = answerList.Count - 2; i >= 0; i--)
        {
            answerList.Add(answerList[i]);
        }
        return string.Join("", answerList);
    }
}