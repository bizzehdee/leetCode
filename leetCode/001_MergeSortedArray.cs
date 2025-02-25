namespace leetCode;

/// <summary>
/// https://leetcode.com/problems/merge-sorted-array?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class MergeSortedArray
{
    public void MergeDotnet(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }


    public void MergeMine(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }

        for (int i = 0; i < n; i++)
        {
            int temp = nums1[m + i];
            int j = m + i - 1;
            while (j >= 0 && nums1[j] > temp)
            {
                nums1[j + 1] = nums1[j];
                j--;
            }
            nums1[j + 1] = temp;
        }    
    }
}
