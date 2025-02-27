namespace leetCode.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/valid-palindrome/description/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while(left <= right)
        {
            // skip non-alphanumeric characters
            while (!char.IsLetterOrDigit(s[left]) && left < right)
            {
                left++;
            }
            while (!char.IsLetterOrDigit(s[right]) && right > left)
            {
                right--;
            }

            // qucik tolower
            var l = (s[left] >= 'a' ? s[left] - 32 : s[left]);
            var r = (s[right] >= 'a' ? s[right] - 32 : s[right]);

            // the actual check
            if (l != r)
            {
                return false;
            }

            // NEXT!
            left++;
            right--;
        }

        // it didnt fail, so it must be correct?
        return true;
    }
}

