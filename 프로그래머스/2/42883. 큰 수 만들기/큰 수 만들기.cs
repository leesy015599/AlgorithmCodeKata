using System;
using System.Text;

public class Solution {
    public string solution(string number, int k) {
        StringBuilder sb = new StringBuilder(number);
        bool flag = false;
        int i;
        int nine = -1;
        while (k > 0)
        {
            flag = false;
            for (i = nine == -1 ? 0 : nine; i < sb.Length - 1; i++)
            {
                if (sb[i] == '9')
                    nine = i;
                if (sb[i] < sb[i + 1])
                {
                    sb.Remove(i, 1);
                    k--;
                    flag = true;
                }
                if (flag)
                    break;
            }
            if (i == sb.Length - 1 && flag == false)
            {
                sb.Remove(sb.Length - 1, 1);
                k--;
            }
        }
        return sb.ToString();
    }
}