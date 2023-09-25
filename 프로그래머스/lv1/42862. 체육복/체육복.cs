using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        int[] students = new int[n];
        Array.Fill(students, 1);
        for (int i = 0; i < lost.Length; i++)
            students[lost[i] - 1] -= 1;
        for (int i = 0; i < reserve.Length; i++)
            students[reserve[i] - 1] += 1;
        
        for (int i = 0; i < n-1; i++)
        {
            if ((students[i] == 0 && students[i+1] == 2)
                || (students[i] == 2 && students[i+1] == 0))
            {
                students[i] = 1;
                students[i+1] = 1;
            }
            if (students[i] != 0)
                ++answer;
        }
        if (students[n-1] != 0)
            ++answer;
        
        return answer;
    }
}