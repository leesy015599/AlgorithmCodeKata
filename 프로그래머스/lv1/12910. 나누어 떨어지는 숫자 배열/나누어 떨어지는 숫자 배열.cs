using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer;
        
        List<int> list = new List<int> ();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
                list.Add(arr[i]);
        }
        answer = new int[list.Count];
        if (list.Count == 0)
        {
            answer = new int[1];
            answer[0] = -1;
            return answer;
        }
        
        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            answer[i] = list[i];
        }
        
        
        return answer;
    }
}