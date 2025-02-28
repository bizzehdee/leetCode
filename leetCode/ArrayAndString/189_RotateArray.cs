using System;

namespace leetCode.ArrayAndString;

/// <summary>
/// https://leetcode.com/problems/rotate-array/description/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class RotateArray
{
    public void RotateMine(int[] nums, int k)
    {
        //if we only have 1 item, whats the point?
        if (nums.Length == 1)
        {
            return;
        }

        //if k is greater than the length of the array, we can just take the remainder
        k = k % nums.Length;
        if (k == 0)
        {
            return;
        }

        //create a temp array to store the last k elements
        var temp = new int[k];

        //copy the last k elements to the temp array
        Array.Copy(nums, nums.Length - k, temp, 0, k);

        //swap the two parts around into the original array
        Array.Copy(nums, 0, nums, k, nums.Length - k);
        Array.Copy(temp, 0, nums, 0, k);
    }
}
