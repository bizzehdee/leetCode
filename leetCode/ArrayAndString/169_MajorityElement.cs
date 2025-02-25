namespace leetCode.ArrayAndString;

/// <summary>
/// https://leetcode.com/problems/majority-element?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class MajorityElement
{
    public int MajorityElementDotnet(int[] nums)
    {
        var k = nums.GroupBy(f => f).OrderByDescending(nums => nums.Count()).First().Key;
        return k;
    }

    public int MajorityElementMine(int[] nums)
    {
        var keyValuePair = new Dictionary<int, int>();
        var k = 0;
        var kv = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (keyValuePair.ContainsKey(nums[i]))
            {
                keyValuePair[nums[i]]++;
            }
            else
            {
                keyValuePair.Add(nums[i], 1);
            }

            if (kv < keyValuePair[nums[i]])
            {
                kv = keyValuePair[nums[i]];
                k = nums[i];
            }
        }

        return k;
    }
}
