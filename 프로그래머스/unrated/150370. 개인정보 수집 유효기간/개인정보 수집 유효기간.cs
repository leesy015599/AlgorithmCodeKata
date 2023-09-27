using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] todayDate = {int.Parse(today.Substring(0, 4))
                           , int.Parse(today.Substring(5, 2))
                           , int.Parse(today.Substring(8, 2))};
        
        Dictionary<char, int> term = new Dictionary<char, int> ();
        
        for (int tIdx = 0; tIdx < terms.Length; tIdx++)
        {
            char cTerm = terms[tIdx][0];
            int iTerm = int.Parse(terms[tIdx].Substring(2));
            term.Add(cTerm, iTerm);
        }
        
        List<int> answer = new List<int> ();
        for (int pIdx = 0; pIdx < privacies.Length; pIdx++)
        {
            string privacy = privacies[pIdx];
            int[] privacyDate = {int.Parse(privacy.Substring(0, 4))
                                 , int.Parse(privacy.Substring(5, 2))
                                 , int.Parse(privacy.Substring(8, 2))};
            char privacyTerm = privacy[privacy.Length - 1];
            int termMonth;
            term.TryGetValue(privacyTerm, out termMonth);
            privacyDate[1] += termMonth;
            privacyDate[2] -= 1;
            privacyDate = FixDate(privacyDate);
            
            Console.WriteLine(privacyDate[0]);
            Console.WriteLine(privacyDate[1]);
            Console.WriteLine(privacyDate[2]);
            
            if (IsLaterDate(privacyDate, todayDate))
                answer.Add(pIdx + 1);
        }
        return answer.ToArray();
    }
    
    private int[] FixDate(int[] date)
    {
        if (date[2] == 0)
        {
            date[1] -= 1;
            date[2] = 28;
        }
        if (date[1] == 0)
        {
            date[0] -= 1;
            date[1] = 12;
        }
        if (date[1] > 12)
        {
            date[0] += date[1] / 12;
            date[1] = date[1] % 12;
        }
        if (date[1] == 0)
        {
            date[0] -= 1;
            date[1] = 12;
        }
        return date;
    }
    
    private bool IsLaterDate(int[] beforeDate, int[] laterDate)
    {
        if (beforeDate[0] < laterDate[0])
            return true;
        if (beforeDate[0] > laterDate[0])
            return false;
        if (beforeDate[1] < laterDate[1])
            return true;
        if (beforeDate[1] > laterDate[1])
            return false;
        if (beforeDate[2] < laterDate[2])
            return true;
        return false;
    }
}