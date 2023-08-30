using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> list = new List<int>();
        while (n != 0)
        {
            list.Add(n % 3);
            n /= 3;
        }
        int answer = 0;
        for (int i = list.Count - 1; i >= 0; i--)
            answer += list[i] * (int)Math.Pow(3, list.Count - 1 - i);
        return answer;
    }
}