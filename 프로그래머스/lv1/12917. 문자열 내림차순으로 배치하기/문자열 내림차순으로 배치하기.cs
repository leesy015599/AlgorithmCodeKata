using System;

public class Solution {
    public string solution(string s) {
        int[] intAnswer = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
            intAnswer[i] = (int)s[i];
        string answer = "";
        Array.Sort(intAnswer);
        Array.Reverse(intAnswer);
        for (int i = 0; i < s.Length; i++)
            answer += (char)intAnswer[i];
        return answer;
    }
}