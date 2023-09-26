using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {wallpaper.Length, wallpaper[0].Length, -1, -1};
        
        for (int row = 0; row < wallpaper.Length; row++)
        {
            for (int col = 0; col < wallpaper[0].Length; col++)
            {
                if (wallpaper[row][col] == '#')
                {
                    if (answer[0] > row)
                        answer[0] = row;
                    if (answer[1] > col)
                        answer[1] = col;
                    if (answer[2] < row + 1)
                        answer[2] = row + 1;
                    if (answer[3] < col + 1)
                        answer[3] = col + 1;
                }
            }
        }
        
        return answer;
    }
}