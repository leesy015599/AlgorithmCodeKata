using System;
using System.Text;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        StringBuilder nkBuilder = new StringBuilder();
        
        while (n != 0)
        {
            nkBuilder.Insert(0, n % k);
            n /= k;
        }
        
        string nk = nkBuilder.ToString();
        string[] strary = nk.Split('0');
        
        for (int i = 0; i < strary.Length; i++)
        {
            if (strary[i].Length == 0)
                continue;
            if (IsPrime(long.Parse(strary[i])))
                ++answer;
        }
        
        return answer;
    }
    
    private bool IsPrime(long num)
    {
        if (num == 1)
            return false;
        if (num == 2 || num == 3)
            return true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}