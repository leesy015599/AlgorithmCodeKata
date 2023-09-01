using System;

public class Solution {
    public int solution(int[,] sizes) {
        int x = 0;
        int y = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int tempX = sizes[i,0] > sizes[i,1] ? sizes[i,0] : sizes[i,1];
            int tempY = sizes[i,0] > sizes[i,1] ? sizes[i,1] : sizes[i,0];
            x = x > tempX ? x : tempX;
            y = y > tempY ? y : tempY;
        }
        return x * y;
    }
}