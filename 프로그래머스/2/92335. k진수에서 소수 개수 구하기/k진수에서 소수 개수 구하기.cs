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
    
    // 1번, 11번 런타임 에러 나옴.
    // 매개변수를 int->long으로 바꾸니 런타임 에러는 해결. 1번 시간초과
    // IsPrime 내부 for문에서 너무 오래걸려서 그러는 듯?
    // 소수 구하는 방식을 좀 더 빠른걸로 바꾸면 해결될 것 같기도?
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