namespace leetCode;

/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicatesFromSortedArrayMine(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k])
            {
                k++;
                nums[k] = nums[i];
            }
        }

        return k + 1;
    }
}
