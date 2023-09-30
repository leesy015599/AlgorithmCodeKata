using System;
using System.Collections.Generic;

public class Solution {
    
    public class Info
    {
        public int id_idx;
        public int reported;
        public List<string> reporters;
        public int mail;
        
        public Info(int idx)
        {
            id_idx = idx;
            reported = 0;
            reporters = new List<string> ();
            mail = 0;
        }
    }
    
    public int[] solution(string[] id_list, string[] report, int k) {
        Dictionary<string, Info> list = new Dictionary<string, Info> ();
        for (int i = 0; i < id_list.Length; i++)
            list.Add(id_list[i], new Info(i));
        for (int i = 0; i < report.Length; i++)
        {
            string reporter = report[i].Substring(0, report[i].IndexOf(" "));
            string reported = report[i].Substring(report[i].IndexOf(" ") + 1);
            if (list[reported].reporters.IndexOf(reporter) == -1)
            {
                ++list[reported].reported;
                list[reported].reporters.Add(reporter);
            }
        }
        for (int i = 0; i < id_list.Length; i++)
        {
            if (list[id_list[i]].reported >= k)
            {
                for (int j = 0; j < list[id_list[i]].reporters.Count; j++)
                    ++list[list[id_list[i]].reporters[j]].mail;
            }
        }
        int[] answer = new int[id_list.Length];
        for (int i = 0; i < id_list.Length; i++)
            answer[i] = list[id_list[i]].mail;
        return answer;
    }
}