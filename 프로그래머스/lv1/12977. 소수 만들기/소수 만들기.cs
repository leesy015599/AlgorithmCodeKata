using System;

class Solution
{
    public int solution(int[] nums)
    {
        int[] three = new int[3];
        int primeCount = 0;
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            three[0] = nums[i];
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                three[1] = nums[j];
                for (int k = j + 1; k < nums.Length; k++)
                {
                    three[2] = nums[k];
                    if (isPrime(three))
                        primeCount++;
                }
            }
        }
        
        return primeCount;
    }
    
    private bool isPrime(int[] three)
    {
        int num = three[0] + three[1] + three[2];
        
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}