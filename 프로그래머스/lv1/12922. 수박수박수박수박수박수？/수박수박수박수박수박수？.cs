public class Solution {
    public string solution(int n) {
        string answer = "";
        int su = 0;
        while (su++ < n)
        {
            if (su % 2 == 1)
                answer += "수";
            else
                answer += "박";
        }
        return answer;
    }
}