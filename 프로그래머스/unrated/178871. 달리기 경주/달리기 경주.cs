using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[players.Length];
        Dictionary<string, int> position = new Dictionary<string, int> ();
        for (int i = 0; i < players.Length; i++)
        {
            position.Add(players[i], i);
            answer[i] = players[i];
        }
        
        for (int i = 0; i < callings.Length; i++)
        {
            int calledIdx = position[callings[i]];
            position[callings[i]] = calledIdx - 1;
            position[answer[calledIdx - 1]] += 1;
            string temp = answer[calledIdx];
            answer[calledIdx] = answer[calledIdx - 1];
            answer[calledIdx - 1] = temp;
        }
        return answer;
    }
}