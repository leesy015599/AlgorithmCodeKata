using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] maps) {
        List<int> days = new List<int>();
        int[,] checker = new int[maps.Length, maps[0].Length];
        for (int a = 0; a < maps.Length; a++)
        {
            for (int b = 0; b < maps[a].Length; b++)
                checker[a,b] = -1;
        }
        for (int i = 0; i < maps.Length; i++)
        {
            for (int j = 0; j < maps[i].Length; j++)
            {
                int foodCount = CountFood(maps, ref checker, i, j);
                if (foodCount != 0)
                {
                    days.Add(foodCount);
                }
            }
        }
        if (days.Count == 0)
            return (new int[1]{-1});
        days.Sort();
                
        return days.ToArray();
    }
    
    public int CountFood(string[] maps, ref int[,] checker, int i, int j)
    {
        int result = 0;
        if (checker[i, j] != -1 || maps[i][j] == 'X')
            return 0;
        result += checker[i, j] = maps[i][j] - '0';
        if (i != 0)
            result += CountFood(maps, ref checker, i-1, j);
        if (i != maps.Length - 1)
            result += CountFood(maps, ref checker, i+1, j);
        if (j != 0)
            result += CountFood(maps, ref checker, i, j-1);
        if (j != maps[0].Length - 1)
            result += CountFood(maps, ref checker, i, j+1);
        return result;
    }
}