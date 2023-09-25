using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        string MBTI = "RTCFJMAN";
        int[] score = new int[8];
        
        // RT(TR) CF(FC) JM(MJ) AN(NA) -> 동점일 경우 전자
        // n개의 질문, 7개의 선택지 (3R 2R 1R 0 1T 2T 3T)
        // survey : "비동의 동의" "RT" (결과지)
        // choices : 선택지
        
        int no;
        int yes;
        int choice;
        
        for (int i = 0; i < survey.Length; i++)
        {
            no = MBTI.IndexOf(survey[i][0]);
            yes = MBTI.IndexOf(survey[i][1]);
            choice = choices[i] - 4;
            if (choice < 0)
                score[no] -= choice;
            else
                score[yes] += choice;
        }
        
        for (int i = 0; i < 4; i++)
            answer += score[i * 2] >= score[i * 2 + 1]
                        ? MBTI[i * 2] : MBTI[i * 2 + 1];
        
        return answer;
    }
}