using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
        Queue<int> priority = new Queue<int> (priorities);
        Queue<int> loc = new Queue<int> ();
        List<int> result = new List<int> ();
        
        for (int i = 0; i < priorities.Length; i++)
            loc.Enqueue(i);
        
        while (priority.Count> 0)
        {
            int now;
            if (priority.TryPeek(out now))
            {
                if (priority.Max() > now)
                {
                    priority.Enqueue(priority.Dequeue());
                    loc.Enqueue(loc.Dequeue());
                }
                else
                {
                    priority.Dequeue();
                    result.Add(loc.Dequeue());
                }
            }
        }
        return result.IndexOf(location) + 1;
    }
}