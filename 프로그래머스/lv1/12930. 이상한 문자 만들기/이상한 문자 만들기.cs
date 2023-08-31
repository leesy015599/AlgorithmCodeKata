using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                index = 0;
                answer += ' ';
            }
            else
            {
                if (index % 2 == 0)
                {
                    if ((int)s[i] >= 'a')
                        answer += (char)((int)s[i] - 32);
                    else
                        answer += s[i];
                }
                else
                {
                    if ((int)s[i] <= 'Z')
                        answer += (char)((int)s[i] + 32);
                    else
                        answer += s[i];
                }
                index++;
            }
        }
        return answer;
    }
}