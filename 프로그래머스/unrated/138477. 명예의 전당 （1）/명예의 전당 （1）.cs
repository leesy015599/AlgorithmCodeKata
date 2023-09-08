using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> honor = new List<int>();
        for (int date = 0; date < score.Length; date++)
        {
            honor.Add(score[date]);
            honor.Sort();
            if (k > date)
                answer[date] = honor[0];
            else
                answer[date] = honor[date - k + 1];
        }
        return answer;
    }
}