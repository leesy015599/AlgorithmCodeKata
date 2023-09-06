using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] a = n.ToString().ToCharArray();
        Array.Sort (a);
        Array.Reverse (a);
        answer = long.Parse(new string(a));
        return answer;
    }
}