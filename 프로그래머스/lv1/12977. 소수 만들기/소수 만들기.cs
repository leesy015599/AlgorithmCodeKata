using System;

class Solution
{
    public int solution(int[] nums)
    {
        int primeCount = 0;
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (isPrime(nums[i] + nums[j] + nums[k]))
                        primeCount++;
                }
            }
        }
        
        return primeCount;
    }
    
    private bool isPrime(int num)
    {
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}