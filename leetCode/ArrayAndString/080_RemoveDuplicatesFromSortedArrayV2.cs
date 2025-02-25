namespace leetCode.ArrayAndString;

/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class RemoveDuplicatesFromSortedArrayV2
{
    public int RemoveDuplicatesFromSortedArrayV2Mine(int[] nums)
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
            else if (k == 0 || nums[k] != nums[k - 1])
            {
                k++;
                nums[k] = nums[i];
            }
        }

        return k + 1;
    }
}
