using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> Fib = new List<int> ();
        Fib.Add(0);
        Fib.Add(1);
        for (int i = 2; i < n + 1; i++)
            Fib.Add((Fib[i - 2] + Fib[i - 1]) % 1234567);
        return Fib[n];
    }
}