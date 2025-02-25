using System;

namespace leetCode.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/is-subsequence/description/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class IsSubsequence
{
    public bool IsSubsequenceMine(string s, string t)
    {
        var found = 0;
        var lastFoundPosition = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int x = lastFoundPosition; x < t.Length; x++)
            {
                if (s[i] == t[x])
                {
                    // found a match for s in t
                    lastFoundPosition = x + 1;
                    found++;
                    break;
                }
            }
        }

        return found >= s.Length;
    }
}
