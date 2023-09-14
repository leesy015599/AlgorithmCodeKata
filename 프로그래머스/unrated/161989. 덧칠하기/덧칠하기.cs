using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int wallPart = section[0];
        int answer = 0;
        for (int i = 0; i < section.Length; i++)
        {
            if (wallPart <= section[i])
            {
                wallPart = section[i];
                wallPart += m;
                answer++;
            }
        }
        return answer;
    }
}