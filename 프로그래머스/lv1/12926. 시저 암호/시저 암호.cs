public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for (int i = 0; i < s.Length; i++)
        {
            int ascii = (int)(s[i]) + n;
            
            if (s[i] == ' ')
                ascii = (int)(s[i]);
            else if (('A' <= s[i]) && (s[i] <= 'Z'))
                ascii = (ascii - 'A') % 26 + 'A';
            else if (('a' <= s[i]) && (s[i] <= 'z'))
                ascii = (ascii - 'a') % 26 + 'a';
            answer += (char)ascii;
        }
        
        return answer;
    }
}