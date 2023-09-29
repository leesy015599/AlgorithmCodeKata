using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] dog = CurrentPosition(park);
        
        for (int i = 0; i < routes.Length; i++)
        {
            char direction = routes[i][0];
            int distance = int.Parse(routes[i].Substring(2));
            if (IsProperRoute(dog, direction, distance, park))
                dog = Move(dog, direction, distance);
        }
        return dog;
    }
    
    private int[] CurrentPosition(string[] park)
    {
        int[] dog = new int[2];
        int height = park.Length;
        int width = park[0].Length;
        
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                if (park[h][w] == 'S')
                {
                    dog[0] = h;
                    dog[1] = w;
                    return dog;
                }
            }
        }
        return dog;
    }
    
    private bool IsProperRoute(int[] dog, char direction, int distance, string[] park)
    {
        int height = park.Length;
        int width = park[0].Length;
        
        int sign = 1;
        if (direction == 'E' || direction == 'W')
        {
            if (direction == 'W')
                sign = -1;
            for (int i = 1; i <= distance; i++)
            {
                if (dog[1] + (sign * i) < 0 || dog[1] + (sign * i) >= width)
                    return false;
                if (park[dog[0]][dog[1] + (sign * i)] == 'X')
                    return false;
            }
        }
        else // S or N
        {
            if (direction == 'N')
                sign = -1;
            for (int i = 1; i <= distance; i++)
            {
                if (dog[0] + (sign * i) < 0 || dog[0] + (sign * i) >= height)
                    return false;
                if (park[dog[0] + (sign * i)][dog[1]] == 'X')
                    return false;
            }
        }
        return true;
    }
    
    private int[] Move(int[] dog, char direction, int distance)
    {
        if (direction == 'E' || direction == 'W')
        {
            if (direction == 'W')
                distance *= -1;
            dog[1] += distance;
        }
        else // S || N
        {
            if (direction == 'N')
                distance *= -1;
            dog[0] += distance;
        }
        return dog;
    }
}