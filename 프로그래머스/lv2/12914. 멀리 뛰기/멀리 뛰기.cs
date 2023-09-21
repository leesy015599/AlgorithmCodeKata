public class Solution {
    long[] howMany = new long[2000];
    
    private long HowMany(int n)
    {
        if (howMany[n - 1] == 0)
        {
            if (howMany[n - 3] == 0)
                HowMany(n - 2);
            if (howMany[n - 2] == 0)
                HowMany(n - 1);
            howMany[n - 1] = (howMany[n - 3] + howMany[n - 2]) % 1234567;
        }
        return howMany[n - 1];
    }
    
    public long solution(int n) {
        howMany[0] = 1;
        howMany[1] = 2;
        return HowMany(n);
    }
}