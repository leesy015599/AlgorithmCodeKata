using System;

class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        string convertNum = ConvertKbinary(n, k);

        int j = 0;
        for (int i = 0; i < convertNum.Length - 1; i = j) {
            for (j = i + 1; j < convertNum.Length && convertNum[j] != '0'; j++) ;
            if (IsPrime(long.Parse(convertNum.Substring(i, j - i))))
                answer++;
        }
        return answer;
    }

    private static bool IsPrime(long num) {
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) return false;
        }
        return true;
    }

    private static string ConvertKbinary(int n, int k) {
        System.Text.StringBuilder str = new System.Text.StringBuilder();

        while (n > 0) {
            str.Append(n % k);
            n /= k;
        }

        char[] charArray = str.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}