public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int len = phone_number.Length;
        for (int i = 0; i < len - 4; i++)
            answer += "*";
        answer = answer + phone_number[len - 4]
                        + phone_number[len - 3]
                        + phone_number[len - 2]
                        + phone_number[len - 1];
        return answer;
    }
}