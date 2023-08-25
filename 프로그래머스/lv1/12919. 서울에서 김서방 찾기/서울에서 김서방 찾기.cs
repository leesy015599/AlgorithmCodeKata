public class Solution {
    public string solution(string[] seoul) {
        int i = 0;
        for (int index = i; index < seoul.Length + 1; index++)
        {
            if (seoul[index] == "Kim")
            {
                i = index;
                break;
            }
        }
        
        string answer = "김서방은 " + i + "에 있다";
        return answer;
    }
}