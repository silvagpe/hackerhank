using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace NeedCode.ArraysAndHashing;
/// <summary>
/// https://neetcode.io/problems/anagram-groups
///Group Anagrams
///Given an array of strings strs, group all anagrams together into sublists. You may return the output in any order.
///
///An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
///
///Example 1:
///
///Input: strs = ["act","pots","tops","cat","stop","hat"]
///
///Output: [["hat"],["act", "cat"],["stop", "pots", "tops"]]
///Example 2:
///
///Input: strs = ["x"]
///
///Output: [["x"]]
///Example 3:
///
///Input: strs = [""]
///
///Output: [[""]]
///Constraints:
///
///1 <= strs.length <= 1000.
///0 <= strs[i].length <= 100
///strs[i] is made up of lowercase English letters.
///
/// </summary>
public class GroupAnagramsTest
{

    public bool isAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        bool result = true;
        for (int i = 0; i < sArr.Length; i++)
        {
            if (sArr[i] != tArr[i])
            {
                result = false;
                break;
            }
        }
        return result;
    }

    public string SortedWord(string word)
    {
        var sArr = word.ToCharArray();
        Array.Sort(sArr);
        return new string(sArr);
    }

    [Theory]
    [InlineData(new string[] { "act", "pots", "tops", "cat", "stop", "hat" }, "[act,cat][pots,tops,stop][hat]")]
    [InlineData(new string[] { "x" }, "[x]")]
    [InlineData(new string[] { "" }, "[]")]
    [InlineData(new string[] { "", "" }, "[]")]
    public void GroupAnagrams(string[] strs, string expected)
    {
        var dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {

            var sortedWord = SortedWord(strs[i]);
            if (!dic.ContainsKey(sortedWord))
                dic.Add(sortedWord, new List<string>() { strs[i] });

            for (int j = i + 1; j < strs.Length; j++)
            {
                if (isAnagram(strs[i], strs[j]))
                {
                    if (dic[sortedWord].Contains(strs[j])) continue;
                    dic[sortedWord].Add(strs[j]);
                }
            }
        }

        var sb = new StringBuilder();
        var list = new List<List<string>>();
        for (int i = 0; i < dic.Keys.Count; i++)
        {
            string key = dic.Keys.ElementAt(i);
            list.Add(dic[key]);
            sb.Append("[");
            sb.Append(string.Join(",", dic[key].ToArray()));
            sb.Append("]");
        }

        var result = sb.ToString();

        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(new string[] { "act", "pots", "tops", "cat", "stop", "hat" }, "[act,cat][pots,tops,stop][hat]")]
    [InlineData(new string[] { "x" }, "[x]")]
    [InlineData(new string[] { "" }, "[]")]
    [InlineData(new string[] { "", "" }, "[]")]
    public void GroupAnagramsV2(string[] strs, string expected)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach (char c in s)
            {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if (!res.ContainsKey(key))
            {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        var result = res.Values.ToList<List<string>>();

        Assert.True(result.Count > 0);
    }
}