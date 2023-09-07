using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        // 중복 놉
        List<int> sum = new List<int>();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (sum.Contains(numbers[i] + numbers[j]) == false)
                    sum.Add(numbers[i] + numbers[j]);
            }
        }
        sum.Sort();
        int[] answer = new int[sum.Count];
        for (int i = 0; i < sum.Count; i++)
            answer[i] = sum[i];
        return answer;
    }
}