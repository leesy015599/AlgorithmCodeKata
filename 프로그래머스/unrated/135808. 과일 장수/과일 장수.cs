using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        Array.Sort(score);
        int len = score.Length;
        int profit = 0;
        while (len - m >= 0)
        {
            int minScore = score[len - m];
            profit += minScore * m;
            len -= m;
        }
        return profit;
    }
}