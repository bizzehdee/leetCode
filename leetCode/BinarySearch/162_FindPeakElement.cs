using System;

namespace leetCode.BinarySearch;

/// <summary>
/// https://leetcode.com/problems/find-peak-element/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class FindPeakElement
{
    public int FindPeakElementMine(int[] nums)
    {
        var max = int.MinValue;
        var maxx = 0;

        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] > max)
            {
                max = nums[x];
                maxx = x;
            }
        }

        return maxx;
    }
}
