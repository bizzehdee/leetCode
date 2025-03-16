using System.Text;

namespace leetCode.Backtracking;

public class LetterCombinationsOfAPhoneNumber
{
    private readonly IDictionary<char, char[]> _numCharMap = new Dictionary<char, char[]>()
    {
        {'2', ['a', 'b', 'c'] },
        {'3', ['d', 'e', 'f'] },
        {'4', ['g', 'h', 'i'] },
        {'5', ['j', 'k', 'l'] },
        {'6', ['m', 'n', 'o'] },
        {'7', ['p', 'q', 'r', 's'] },
        {'8', ['t', 'u', 'v'] },
        {'9', ['w', 'x', 'y', 'z'] }
    };
    
    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        if (digits.Length == 0)
        {
            return result;
        }
        
        var sb = new StringBuilder();
        Backtrack(result, sb, digits, 0);
        
        return result;
    }

    private void Backtrack(List<string> result, StringBuilder sb, string digits, int i)
    {
        if (sb.Length == digits.Length)
        {
            result.Add(sb.ToString());
            return;
        }

        var num = digits[i];
        var chars = _numCharMap[num];
        foreach (var c in chars)
        {
            sb.Append(c);
            Backtrack(result, sb, digits, i + 1);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}