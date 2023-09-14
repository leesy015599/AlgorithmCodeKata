using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int weight = 0;
        
        for (int i = 1; i <= number; i++)
        {
            if (CountDivisor(i) > limit)
                weight += power;
            else
                weight += CountDivisor(i);
        }
        
        return weight;
    }
    
    private int CountDivisor(int number)
    {
        int divisorCount = 0;
        
        for (int i = 1; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                divisorCount++;
                if (i * i != number)
                    divisorCount++;
            }
        }
        
        return divisorCount;
    }
}