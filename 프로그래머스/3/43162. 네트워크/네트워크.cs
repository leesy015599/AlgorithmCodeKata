using System;

public class Solution {
    public int[,] com;
    public bool[] isNotAlone;
    public int N;
    public int answer;
    
    public int solution(int n, int[,] computers) {
        com = computers;
        isNotAlone = new bool[n];
        N = n;
        answer = 0;
        
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (x == y)
                    continue;
                if (com[x, y] == 1)
                {
                    com[x, y] = -1;
                    com[y, x] = -1;
                    isNotAlone[x] = true;
                    isNotAlone[y] = true;
                    func(y);
                    answer++;
                }
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            if (isNotAlone[i] == false)
                answer++;
        }
        
        return answer;
    }
    
    public void func(int x)
    {
        for (int y = 0; y < N; y++)
        {
            if (x == y)
                continue;
            if (com[x, y] == 1)
            {
                com[x, y] = -1;
                com[y, x] = -1;
                isNotAlone[x] = true;
                isNotAlone[y] = true;
                func(y);
            }                
        }
    }
}