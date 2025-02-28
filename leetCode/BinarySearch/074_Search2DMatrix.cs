using System;

namespace leetCode.BinarySearch;

/// <summary>
/// https://leetcode.com/problems/search-a-2d-matrix/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class Search2DMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int y = 0; y < matrix.Length; y++)
        {
            var row = matrix[y];
            if (target > row[row.Length - 1]) continue;

            for (int x = 0; x < row.Length; x++)
            {
                if (target == row[x]) return true;
            }
        }

        return false;
    }
}
