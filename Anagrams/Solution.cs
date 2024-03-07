namespace Anagrams;

public class Solution
{
    public static IEnumerable<string> GetAnagrams(string s)
    {
        return s.Length switch
        {
            0 => [],
            1 => [s],
            _ => GetAnagrams(s[1..]).SelectMany(anagram => GetCombinations(s[0], anagram)).Distinct()
        };
    }
    
    public static IEnumerable<string> GetCombinations(char c, string s)
    {
        for (var i = 0; i <= s.Length; i++)
        {
            var prefix = s[..i];
            var suffix = s[i..];
            yield return prefix + c + suffix;
        }
    }
}
