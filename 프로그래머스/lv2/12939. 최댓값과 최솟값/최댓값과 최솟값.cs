using System;

public class Solution {
    public string solution(string s) {
        string[] split = s.Split(' ');
        string min = "";
        string max = "";
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length == 0)
                continue;
            if (min.Length == 0) // 초기값 설정
            {
                min = split[i];
                max = split[i];
                continue;
            }
            if (IsLargerThan(split[i], max))
                max = split[i];
            else if (IsLargerThan(min, split[i]))
                min = split[i];
        }
        
        string answer = min;
        answer += " ";
        answer += max;
        return answer;
    }
    
    private bool IsLargerThan(string large, string small)
    {
        if (large[0] != '-' && small[0] == '-')
            return true;
        if (large[0] == '-' && small[0] != '-')
            return false;
        
        if (large[0] != '-') // 둘 다 양수
        {
            if (large.Length > small.Length)
                return true;
            else if (large.Length < small.Length)
                return false;
            return (String.Compare(large, small) > 0) ? true : false;
        }
        else // 둘 다 음수
        {
            if (large.Length > small.Length)
                return false;
            else if (large.Length < small.Length)
                return true;
            return (String.Compare(large.Substring(1), small.Substring(1)) > 0) ? false : true;
        }
        return false;
    }
}