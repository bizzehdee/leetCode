namespace leetCode;

/// <summary>
/// https://leetcode.com/problems/remove-element?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class RemoveElement
{
    public int RemoveElementMine(int[] nums, int val)
    {
        int k = 0;
        int maxK = nums.Length;

        var tempArray = new int[maxK];

        for (int x = 0; x < maxK; x++)
        {
            tempArray[k] = nums[x];
            if (nums[x] != val)
            {
                k++;
            }
        }

        for (int i = 0; i < maxK; i++)
        {
            nums[i] = tempArray[i];
        }

        return k;
    }
}
