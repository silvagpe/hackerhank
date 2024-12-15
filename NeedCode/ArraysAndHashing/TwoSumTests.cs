namespace NeedCode.ArraysAndHashing;
/// <summary>
/// https://neetcode.io/problems/two-integer-sum
//Two Sum
//Given an array of integers nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.
//
//You may assume that every input has exactly one pair of indices i and j that satisfy the condition.
//
//Return the answer with the smaller index first.
//
//Example 1:
//
//Input: 
//nums = [3,4,5,6], target = 7
//
//Output: [0,1]
//Explanation: nums[0] + nums[1] == 7, so we return [0, 1].
//
//Example 2:
//
//Input: nums = [4,5,6], target = 10
//
//Output: [0,2]
//Example 3:
//
//Input: nums = [5,5], target = 10
//
//Output: [0,1]
//Constraints:
//
//2 <= nums.length <= 1000
//-10,000,000 <= nums[i] <= 10,000,000
//-10,000,000 <= target <= 10,000,000
//
/// </summary>
public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
    [InlineData(new int[] { 4, 5, 6 }, 10, new int[] { 0, 2 })]
    [InlineData(new int[] { 5, 5 }, 10, new int[] { 0, 1 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        var result = new int[2];
        bool isFounded = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    isFounded = true;
                    break;
                }                
            }
            if (isFounded) break;
        }

        Assert.Equal(expected, result.ToArray());
    }
}