using System.Text;

public class Solution {
    public string solution(string s) {
        string[] split = s.Split(' ');
        StringBuilder build = new StringBuilder();
        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < split.Length; i++)
        {
            build.Clear();
            if (split[i].Length != 0)
            {
                if (split[i][0] >= 'a' && split[i][0] <= 'z')
                    build.Append((char)(split[i][0] + 'A' - 'a'));
                else
                    build.Append(split[i][0]);
                build.Append(split[i].Substring(1).ToLower());
                answer.Append(build);
                if (i != split.Length - 1)
                    answer.Append(' ');
            }
            else if (i != split.Length - 1)
                answer.Append(' ');
        }
        return answer.ToString();
    }
}