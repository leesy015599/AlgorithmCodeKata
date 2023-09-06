using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int[] subary = new int[commands[i,1] - commands[i,0] + 1];
            for (int j = commands[i,0] - 1; j < commands[i,1]; j++)
                subary[j - commands[i,0]+ 1] = array[j];
            Array.Sort(subary);
            answer[i] = subary[commands[i,2] - 1];
        }
        
        return answer;
    }
}