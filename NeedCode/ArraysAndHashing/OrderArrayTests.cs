namespace NeedCode.ArraysAndHashing;

public class OrderArrayTests
{
    [Theory]
    [InlineData(new int[] { 8, 1, 3, 7, 6, 5, 4, 2 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
    [InlineData(new int[] { 8, 1, 3, 7, 6, 5, 4, 3 }, new int[] { 1, 3, 3, 4, 5, 6, 7, 8 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, -6 }, new int[] { -6, 1, 2, 3, 4, 5 })]
    public void OrderAscArray(int[] nums, int[] expected)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                {
                    var tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
            }
        }

        Assert.Equal(expected, nums);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
    public void OrderDescArray(int[] nums, int[] expected)
    {
        for (int i = nums.Length-1; i >= 0; i--)
        {
            for (int j = i -1; j >= 0; j--)
            {
                if (nums[j] < nums[i])
                {
                    var tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
            }
        }

        Assert.Equal(expected, nums);
    }
}