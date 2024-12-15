namespace NeedCode.ArraysAndHashing;
/// <summary>
/// https://neetcode.io/problems/is-anagram
/// Valid Anagram
///Solved 
///Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
///An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
///Example 1:
///Input: s = "racecar", t = "carrace"
///Output: true
/// 
///Example 2:
///Input: s = "jar", t = "jam"
///Output: false
/// 
///Constraints:
///s and t consist of lowercase English letters.
/// </summary>
public class ValidAnagramTests
{
    [Theory]
    [InlineData("racecar", "carrace", true)]
    [InlineData("jar", "jam", false)]
    [InlineData("bbcc", "ccbc", false)]
    public void IsAnagram_v2(string s, string t, bool expected)
    {
        if (s.Length != t.Length)
        {
            Assert.Equal(expected, false);
            return;
        }

        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();

        Array.Sort(sArr);
        Array.Sort(tArr);

        var result = true;
        for (int i = 0; i < sArr.Length; i++){
            if (sArr[i] != tArr[i]){
                result = false;
                break;                
            }
        }

        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("racecar", "carrace", true)]
    [InlineData("jar", "jam", false)]
    [InlineData("bbcc", "ccbc", false)]
    public void IsAnagram_v1(string s, string t, bool expected)
    {
        if (s.Length != t.Length)
        {
            Assert.Equal(expected, false);
            return;
        }

        var list1 = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            list1.Add(s[i]);
        }

        var list2 = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            list2.Add(t[i]);
        }

        var count = list1.Where(x => list2.Contains(x)).Count();

        Assert.Equal(expected, count == s.Length);
    }
}