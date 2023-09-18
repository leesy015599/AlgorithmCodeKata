using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] able = new string[4] {"aya", "ye", "woo", "ma"};
        int answer = babbling.Length;
        for (int i = 0; i < babbling.Length; i++)
        {
            string bab = babbling[i];
            bool wrong = false;
            for (int j = 0; j < able.Length; j++)
            {
                bab = bab.Replace(able[j], $"{j}");
                if (bab.IndexOf($"{j}{j}") != -1)
                    wrong = true;
            }
            for (int j = 0; j < able.Length; j++)
                bab = bab.Replace($"{j}", "");
            if (bab.Length != 0)
                wrong = true;
            if (wrong == true)
                --answer;
        }
        return answer;
    }
}