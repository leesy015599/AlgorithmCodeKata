using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int c1 = 0;
        int c2 = 0;
        for (int gIndex = 0; gIndex < goal.Length; gIndex++)
        {
            if (c1 < cards1.Length && cards1[c1] == goal[gIndex])
            {
                c1++;
                continue;
            }
            else if (c2 < cards2.Length && cards2[c2] == goal[gIndex])
            {
                c2++;
                continue;
            }
            else
                return "No";
        }
        return "Yes";
        // int prevIndex1 = 0;
        // int prevIndex2 = 0;
        // for (int gIndex = 0; gIndex < goal.Length; gIndex++)
        // {
        //     for (int c1Index = 0; c1Index < cards1.Length; c1Index++)
        //     {
        //         if (cards1[c1Index] == goal[gIndex])
        //         {
        //             if (c1Index < prevIndex1)
        //                 return "No";
        //             prevIndex1 = c1Index;
        //             break;
        //         }
        //     }
        //     for (int c2Index = 0; c2Index < cards2.Length; c2Index++)
        //     {
        //         if (cards2[c2Index] == goal[gIndex])
        //         {
        //             if (c2Index < prevIndex2)
        //                 return "No";
        //             prevIndex2 = c2Index;
        //             break;
        //         }
        //     }
        // }
        // return "Yes";
    }
}