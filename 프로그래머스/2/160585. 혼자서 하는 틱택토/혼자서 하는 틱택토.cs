using System; // 왜안올라가

public class Solution {
    public int solution(string[] board) {
        int oCount = 0;
        int xCount = 0;
        if (IsProperOrder(board, ref oCount, ref xCount) == false)
            return 0;
        if (oCount > 2 || xCount > 2)
        {
            if (IsProperEnd(board, oCount, xCount) == false)
                return 0;
        }
        return 1;
    }
    
    public bool IsProperEnd(string[] board, int oNum, int xNum)
    {
        int oCount = 0;
        int xCount = 0;
        for (int i = 0; i < 3; i++)
        {
            if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
            {
                if (board[i][0] != '.')
                {
                    if (board[i][0] == 'O')
                        oCount++;
                    else
                        xCount++;
                }
            }
            if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
            {
                if (board[0][i] != '.')
                {
                    if (board[0][i] == 'O')
                        oCount++;
                    else
                        xCount++;
                }
            }  
        }
        if (board[1][1] != '.')
        {
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
            {
                if (board[1][1] == 'O')
                        oCount++;
                    else
                        xCount++;
            }
            if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
            {
                if (board[1][1] == 'O')
                        oCount++;
                    else
                        xCount++;
            }
        }
        
        if (oCount + xCount > 1 && (oCount != 0 && xCount != 0))
            return false;
        if (oNum == xNum && oCount != 0)
            return false;
        if (oNum > xNum && xCount != 0)
            return false;
        return true;
    }
    
    public bool IsProperOrder(string[] board, ref int oCount, ref int xCount)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i][j] == 'O')
                    oCount++;
                else if (board[i][j] == 'X')
                    xCount++;
            }
        }
        if (oCount < xCount)
            return false;
        if (oCount == xCount)
            return true;
        return (oCount - 1 == xCount) ? true : false;
    }
}