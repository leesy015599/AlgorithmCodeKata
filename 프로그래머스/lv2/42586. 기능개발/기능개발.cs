using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        Queue<int> progress = new Queue<int> (progresses);
        Queue<int> speed = new Queue<int> (speeds);
        List<int> answer = new List<int> ();

        int day = 0;
        while (progress.Count != 0)
        {
            int releaseCount = 0;
            while (progress.Count != 0)
            {
                if (progress.Peek() + (speed.Peek() * day) >= 100)
                {
                    ++releaseCount;
                    progress.Dequeue();
                    speed.Dequeue();
                }
                else
                    break;
            }
            if (releaseCount != 0)
                answer.Add(releaseCount);
            ++day;
        }
        
        return answer.ToArray();
    }
}