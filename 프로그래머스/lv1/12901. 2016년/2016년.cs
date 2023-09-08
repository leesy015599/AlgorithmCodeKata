public class Solution {
    public string solution(int a, int b) {
        while (--a != 0)
        {
            switch (a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    b += 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    b += 30;
                    break;
                default: // case 2:
                    b += 29;
                    break;
            }
        }
        switch (b % 7)
        {
            case 0:
                return "THU";
            case 1:
                return "FRI";
            case 2:
                return "SAT";
            case 3:
                return "SUN";
            case 4:
                return "MON";
            case 5:
                return "TUE";
            default: // case 6:
                return "WED";
        }
    }
}