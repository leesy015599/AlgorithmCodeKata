using System;
using System.Text;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        
        while (s != "1")
        {
            answer[1] += RemoveZero(ref s);
            ChangeIntoBinary(ref s);
            ++answer[0];
        }
        
        return answer;
    }
    
    private int RemoveZero(ref string s)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
                str.Append('1');
        }
        int removedZero = s.Length;
        s = str.ToString();
        removedZero -= s.Length;
        return removedZero;
    }
    
    private void ChangeIntoBinary(ref string s)
    {
        StringBuilder str = new StringBuilder();
        int number = s.Length;
        while (number != 0)
        {
            str.Append(number % 2);
            number /= 2;
        }
        char[] temp = str.ToString().ToCharArray();
        Array.Reverse(temp);
        s = new string(temp);
    }
}