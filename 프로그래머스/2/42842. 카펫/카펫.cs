using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int total = brown + yellow;
        for (int width = 3; width < total; width++)
        {
            int height = total / width;
            if (height > width)
                continue;
            if (brown == 2 * width + 2 * height - 4)
                return (new int[2] {width, height});
        }
        return null;
    }
}