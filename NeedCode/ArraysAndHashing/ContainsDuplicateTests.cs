namespace NeedCode.ArraysAndHashing;

/// <summary>
/// https://neetcode.io/problems/duplicate-integer
/// Contains Duplicate
/// Solved 
///Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
///Example 1:
///Input: nums = [1, 2, 3, 3]
///Output: true

///Example 2:
///Input: nums = [1, 2, 3, 4]
///Output: false
/// </summary>
public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    public void hasDuplicate(int[] nums, bool expected)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i], 1);
            }

            if (dic.Any(x => x.Value > 1)){
                break;
            }
        }

        var result = dic.Any(x => x.Value > 1);
        Assert.Equal(expected, result);
    }
}