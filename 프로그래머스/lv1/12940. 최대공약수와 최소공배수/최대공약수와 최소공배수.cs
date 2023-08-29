using System.Collections.Generic;
using System;

public class Solution {
    public int[] solution(int n, int m) {
        int maxDiv = 1;
        int minMul = 1;
        
        List<int> nFactors = new List<int>();
        List<int> mFactors = new List<int>();
        
        while (n != 1 || m != 1)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    nFactors.Add(i);
                    n /= i;
                    if (i != 1)
                        break ;
                }
            }
            for (int j = 1; j <= m; j++)
            {
                if (m % j == 0)
                {
                    mFactors.Add(j);
                    m /= j;
                    if (j != 1)
                        break ;
                }
            }
        }
        
        int nIndex = nFactors.Count - 1;
        int mIndex = mFactors.Count - 1;
        nFactors.Sort();
        mFactors.Sort();
        
        while (nIndex >= 0 || mIndex >= 0)
        {
            if (nFactors[nIndex] == mFactors[mIndex])
            {
                maxDiv *= nFactors[nIndex];
                minMul *= nFactors[nIndex];
                nIndex--;
                mIndex--;
            }
            else if (nFactors[nIndex] > mFactors[mIndex])
            {
                minMul *= nFactors[nIndex];
                nIndex--;
            }
            else // nF[nI] < mF[mI]
            {
                minMul *= mFactors[mIndex];
                mIndex--;
            }
        }        
        
        int[] answer = new int[2] {maxDiv, minMul};
        return answer;
    }
}