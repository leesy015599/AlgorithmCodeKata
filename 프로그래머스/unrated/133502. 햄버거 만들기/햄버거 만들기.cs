using System;
using System.Collections.Generic;

public class Solution {
    int[] burger = {1, 2, 3, 1};
    
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> ingrd = new List<int>();
        
        for (int i = 0; i < ingredient.Length; i++)
        {
            ingrd.Add(ingredient[i]);
            if (ingrd.Count >= 4)
                answer += CheckBurger(ref ingrd, ingrd.Count - 4) ? 1 : 0;
        }
        
        return answer;
    }
    
    private bool CheckBurger(ref List<int> ingrd, int index)
    {
        int burgerIdx = 0;
        for (int i = index; i < ingrd.Count; i++)
        {
            if (ingrd[i] == burger[burgerIdx])
                ++burgerIdx;
            else
                burgerIdx = 0;
            if (burgerIdx == 4)
            {
                ingrd.RemoveRange(i - 3, 4);
                return true;
            }
        }
        return false;
    }
}