using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] word = {"aya", "ye", "woo", "ma"};
        int answer = 0;
        for (int i = 0; i < babbling.Length; i++)
        {
            int loc = -1;
            for (int j = 0; j < word.Length; j++)
            {
                loc = babbling[i].IndexOf(word[j]);
                if (loc != -1)
                {
                    babbling[i] = babbling[i].Substring(0, loc) + "." + babbling[i].Substring(loc + word[j].Length);
                }
            }
            Console.Write(babbling[i]);
            babbling[i] = babbling[i].Replace(".","");
            Console.Write("\n***" + babbling[i]);
            if (babbling[i].Length == 0)
                answer++;
            Console.Write("\n");
        }
        return answer;
    }
}