using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        for (int index = 0; index < s.Length; index++)
        {
            if (('0' <= s[index]) && (s[index] <= '9'))
                answer = answer * 10 + (int)s[index] - (int)'0';
            else // if s[i] is alphabet
            {
                string alpha = "";
                while ((AlphaToNum(alpha) == -1) && (index < s.Length))
                    alpha += s[index++];
                if (index != s.Length)
                    index--;
                answer = answer * 10 + AlphaToNum(alpha);
            }
        }
        return answer;
    }
    
    int AlphaToNum(string alpha)
{
    switch (alpha)
    {
        case "zero":
            return 0;
        case "one":
            return 1;
        case "two":
            return 2;
        case "three":
            return 3;
        case "four":
            return 4;
        case "five":
            return 5;
        case "six":
            return 6;
        case "seven":
            return 7;
        case "eight":
            return 8;
        case "nine":
            return 9;
    }
    return -1;
}
    
}

