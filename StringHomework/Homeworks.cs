using System.Text;

namespace StringHomework;

public class ParsDigit
{
    public static string Solution(string s)
    {
        StringBuilder result = new();
        foreach(char ch in s)
        {
            if (char.IsDigit(ch))
                result.Append(ch);
        }
        return result.ToString();
    }
}


public class CapitalizeText
{
    public static string Solution(string s)
    {
        StringBuilder result = new();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            result.Append(char.ToUpper(word[0]) + word[1..]);
            if (word != words[^1])
                result.Append(' ');
        }
        return result.ToString();
    }
}


public class IsPalindrom
{
    public static bool Solution(string s)
    {
        StringBuilder result = new();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            result.Append(s[i]);
        }
        return s.Equals(result.ToString(), StringComparison.OrdinalIgnoreCase);
    }
}


public class IsAnnagram
{
    public static bool Solution(string s1, string s2)
    {
        Dictionary<char, int> charCount = new();
        CorrectCharCount(charCount, s1, 1);
        CorrectCharCount(charCount, s2, -1);

        foreach (int value in charCount.Values)
            if (value != 0)
                return false;

        return true;
    }

    private static void CorrectCharCount(Dictionary<char, int> charCount, string s, int postfix = 1)
    {
        foreach (char ch in s)
        {
            if (charCount.ContainsKey(ch))
                charCount[ch] += postfix;
            else
                charCount[ch] = postfix;
        }
    }
}


public class LongestUniqueSubstring
{
    // Example: s = "abcdefg" -> "abcdefg"
    // Example: s = "abbdefg" -> "bdefg"
    // Example: s = "abbdeefg" -> "bde" or "efg"
    public static string Solution(string s)
    {
        int l = 0, r = 0;
        int currentLength = 0, maxLength = 0, resultStartIndex = 0, n = s.Length;
        while (r < n)
        {
            if (r < n && !s.Substring(l, currentLength).Contains(s[r]) || r == l)
                r++;
            else
                l++;
            currentLength = r - l;
            if (maxLength < currentLength)
            {
                maxLength = currentLength;
                resultStartIndex = l;
            }
        }
        return s.Substring(resultStartIndex, maxLength);
    }
}
