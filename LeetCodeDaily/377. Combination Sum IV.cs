// Given an array of distinct integers nums and a target integer target, return the number of possible combinations that add up to target.

// The test cases are generated so that the answer can fit in a 32-bit integer.

 

// Example 1:

// Input: nums = [1,2,3], target = 4
// Output: 7
// Explanation:
// The possible combination ways are:
// (1, 1, 1, 1)
// (1, 1, 2)
// (1, 2, 1)
// (1, 3)
// (2, 1, 1)
// (2, 2)
// (3, 1)
// Note that different sequences are counted as different combinations.
// Example 2:

// Input: nums = [9], target = 3
// Output: 0

public class Solution {

    private int Sum(int [] nums, int i, int j, int target, int count)
    {
        if(i == j && i == nums.Length) return count;
        if(nums[i] + nums[j] == target)
        {
            count++;
        } else {
           if(nums[i])
        }
    }

    public int CombinationSum4(int[] nums, int target) {
        return Sum(nums, 0, 0, target, 0));
    }
}