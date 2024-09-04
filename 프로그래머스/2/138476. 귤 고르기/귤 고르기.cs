using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        // 1 3 2 5 4 5 2 3
        // 1 2 2 3 3 4 5 5 -> k : 6 -> answer : 3
        // 6개 반환할 때, 최대한 일정하게 -> 최대한 겹치게.
        
        Dictionary<int, int> container = new Dictionary<int, int>();
        foreach (var i in tangerine)
        {
            if (container.ContainsKey(i))
                container[i] += 1;
            else
                container.Add(i, 1);
        }
        
        List<int> values = new List<int>();
        foreach (var dict in container)
        {
            values.Add(dict.Value);
        }
        values.Sort();
        values.Reverse();
        int answer = 0;
        int sum = 0;
        int j = 0;
        while (true)
        {
            if (sum >= k)
                break;
            sum += values[j++];
            answer++;
        }

        return answer;
    }
}