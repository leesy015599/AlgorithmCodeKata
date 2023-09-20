using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int[] students = new int[n];
        Array.Fill(students, 1);
        for (int i = 0; i < lost.Length; i++)
            students[lost[i] - 1] -= 1;
        for (int j = 0; j < reserve.Length; j++)
            students[reserve[j] - 1] += 1;
        for (int k = 0; k < n; k++)
        {
            if (students[k] == 0)
            {
                if (k != 0 && students[k - 1] == 2)
                {
                    students[k - 1] -= 1;
                    students[k] += 1;
                    answer++;
                }
                else if (k != (n - 1) && students[k + 1] == 2)
                {
                    students[k + 1] -= 1;
                    students[k] += 1;
                    answer++;
                }
            }
            else
                answer++;
        }
        return answer;
    }
}