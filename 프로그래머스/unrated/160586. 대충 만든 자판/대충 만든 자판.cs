using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int[] alpha = new int[26];
        
        for (int str = 0; str < keymap.Length; str++)
        {
            for (int chr = 0; chr < keymap[str].Length; chr++)
            {
                int alphaAscii = keymap[str][chr] - 'A';
                if (alpha[alphaAscii] > chr + 1 || alpha[alphaAscii] == 0)
                    alpha[alphaAscii] = chr + 1;
            }
        }
        
        for (int tar = 0; tar < targets.Length; tar++)
        {
            for (int chr = 0; chr < targets[tar].Length; chr++)
            {
                int alphaAscii = targets[tar][chr] - 'A';
                answer[tar] += alpha[alphaAscii];
                if (alpha[alphaAscii] == 0)
                {
                    answer[tar] = -1;
                    break;
                }
            }
        }
        
        return answer;
    }
}