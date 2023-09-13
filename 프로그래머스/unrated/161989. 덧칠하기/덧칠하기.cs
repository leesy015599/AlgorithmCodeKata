using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int sectionIndex = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i < section[sectionIndex])
                continue;
            i = i + m - 1; // 이 칸까지 칠했음
            while (true)
            {
                sectionIndex++;
                if (sectionIndex >= section.Length)
                    break;
                if (i < section[sectionIndex])
                    break;
            }                
            answer++;
            if (sectionIndex >= section.Length)
                break;
        }
        return answer;
    }
}