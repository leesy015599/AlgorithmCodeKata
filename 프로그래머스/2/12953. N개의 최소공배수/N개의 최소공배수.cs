using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] arr) {
        int answer = 1;
        
        var commonDivisors = new Dictionary<int, int> ();
        for (int i = 0; i < arr.Length; i++)
        {
            Dictionary<int, int> divisors = GetDivisors(arr[i]);
            foreach (KeyValuePair<int, int> item in divisors)
            {
                if (commonDivisors.ContainsKey(item.Key))
                {
                    if (commonDivisors[item.Key] < item.Value)
                        commonDivisors[item.Key] = item.Value;
                }
                else
                    commonDivisors.Add(item.Key, item.Value);
            }
        }
        
        foreach (KeyValuePair<int, int> item in commonDivisors)
        {
            answer *= (int)Math.Pow(item.Key, item.Value);
        }
        
        return answer;
    }
    
    private Dictionary<int, int> GetDivisors(int num)
    {
        var divs = new Dictionary<int, int>();
        divs.Add(1, 1);
        
        while (num != 0)
        {
            int divisor = 1;
            while (++divisor <= num)
            {
                if (num % divisor == 0)
                {
                    if (divs.ContainsKey(divisor))
                        divs[divisor] = divs[divisor] + 1;
                    else
                        divs.Add(divisor, 1);
                    break;
                }
            }
            num /= divisor;
        }
        
        return divs;
    }
}