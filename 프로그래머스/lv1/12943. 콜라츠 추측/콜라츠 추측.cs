using System;

public class Solution {
    public int solution(int num) {
        long lnum = (long)num;
        if (lnum == 1)
            return 0;
        int count = 0;
        while (true)
        {
            if (lnum % 2 == 0)
                lnum /= 2;
            else // num % 2 == 1
                lnum = (lnum * 3) + 1;
            count++;
            if (lnum == 1)
                break;
            if (count == 500)
                return -1;
        }
        return count;
    }
}