using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        int[] skipAry = new int[26];
        for (int i = 0; i < skip.Length; i++)
            skipAry[skip[i] - 'a'] = 1;
        
        for (int i = 0; i < s.Length; i++)
        {
            int indexCount = index;
            for (int j = 0; j < indexCount; j++)
                indexCount += skipAry[(s[i] + j + 1 - 'a') % 26];
            answer += Convert.ToChar((s[i] + indexCount - 'a') % 26 + 'a');
        }
        return answer;
    }
}