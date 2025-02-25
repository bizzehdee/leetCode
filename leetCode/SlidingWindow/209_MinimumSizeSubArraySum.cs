using System;

namespace leetCode.SlidingWindow;

/// <summary>
/// https://leetcode.com/problems/minimum-size-subarray-sum/description/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class MinimumSizeSubArraySum
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        int sum = 0;
        int minLen = int.MaxValue;

        for (var right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        return minLen == int.MaxValue ? 0 : minLen;
    }
}
