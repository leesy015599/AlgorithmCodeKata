using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        List<int> tan = new List<int>(tangerine);
        tan.Sort();
        int[] counter =  new int[tan[tan.Count - 1] + 1];        
        foreach (var val in tan)
            counter[val - 1]++;
        List<int> count = new List<int>(counter);
        count.Sort();
        count.Reverse();
        int idx = 0;
        while (k > 0 && idx < count.Count - 1)
        {
            k -= count[idx];
            idx++;
        }
        
        return idx;
    }
}