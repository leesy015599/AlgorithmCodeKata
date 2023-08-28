public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        if (arr.Length == 1)
            answer = new int[1] {-1};
        else
        {
            answer = new int[arr.Length - 1];
            int min = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            for (int i = 0; i < answer.Length; i++)
            {
                if (i < minIndex)
                    answer[i] = arr[i];
                else
                    answer[i] = arr[i + 1];
            }
        }
        return answer;
    }
}