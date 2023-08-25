public class Solution {
    public int solution(string s) {
        int size = s.Length;
        int sign = 0;
        if (s[0] == '+' || s[0] == '-')
        {
            if (s[0] == '-')
                sign = -1;
            else if (s[0] == '+')
                sign = 1;
        }
        int answer = 0;
        int ten = 1;
        int i = 0;
        if ((sign == 1) || (sign == -1))
        {
            i = 1;
        }
        for (int index = i; index < size; index++)
        {
            answer *= 10;
            answer += ((int)(s[index]) - 48);
        }
        if (sign != 0)
            answer *= sign;
        return answer;
    }
}