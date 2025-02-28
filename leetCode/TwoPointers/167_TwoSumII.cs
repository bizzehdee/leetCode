using System;

namespace leetCode.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class TwoSumII
{
    public int[] TwoSumMine(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        // Since the array is sorted, we can use two pointers to find the sum
        while (left < right)
        {
            var total = numbers[left] + numbers[right];

            if (total == target)
            {
                return new int[] { left + 1, right + 1 };
            }
            else if (total < target)
            {
                // If the total is less than the target, we need to increase the sum
                left++;
            }
            else
            {
                // If the total is greater than the target, we need to decrease the sum
                right--;
            }
        }

        return new int[] { 0, 0 };
    }
}
