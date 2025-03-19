namespace leetCode.Matrix;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var hashset = new HashSet<char>();
        for (var c = 0; c < 9; c++)
        {
            //check row
            for (var i = 0; i < 9; i++)
            {
                if (board[c][i] == '.')
                {
                    continue;
                }
                
                if (!hashset.Add(board[c][i]))
                {
                    return false;
                }
            }
            hashset.Clear();
            
            //check column
            for (var i = 0; i < 9; i++)
            {
                if (board[i][c] == '.')
                {
                    continue;
                }
                
                if (!hashset.Add(board[i][c]))
                {
                    return false;
                }
            }
            hashset.Clear();
            
            //check 3x3
            for(var x=0; x<3; x++)
            {
                for(var y=0; y<3; y++)
                {
                    var i = c / 3 * 3 + x;
                    var j = c % 3 * 3 + y;
                    if (board[i][j] == '.')
                    {
                        continue;
                    }
                    
                    if (!hashset.Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }
            hashset.Clear();
        }
        return true;
    }
}