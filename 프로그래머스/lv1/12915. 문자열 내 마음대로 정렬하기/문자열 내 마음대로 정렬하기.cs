using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        strings = strings.OrderBy(str => str).ToArray();
        strings = strings.OrderBy(str => str[n]).ToArray();
        return strings;
    }
}