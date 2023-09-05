///https://leetcode.com/problems/move-zeroes/
///Given an integer array nums, move all 0's to the end of it while
///maintaining the relative order of the non-zero elements.

// Note that you must do this in-place without making a copy of the array.

 

// Example 1:

// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]
// Example 2:

// Input: nums = [0]
// Output: [0]

public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        int index =0;
        while(i < nums.Length)
        {
            if( nums[i] != 0)
            {
                nums[index++] = nums[i];
            }
            i++;
        }

        i = 0;
        while(index < nums.Length)
        {
            nums[index++] = 0;
        }

    }
}