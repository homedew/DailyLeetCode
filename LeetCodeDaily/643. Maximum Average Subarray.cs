// You are given an integer array nums consisting of n elements, and an integer k.

// Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

// Example 1:

// Input: nums = [1,12,-5,-6,50,3], k = 4
// Output: 12.75000
// Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
// Example 2:

// Input: nums = [5], k = 1
// Output: 5.00000

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int max = Int32.MinValue;
        if(nums.Length == 1) 
        {
            double res  = nums[0] / k;
             Math.Round(res, 2);
            return res;
        }
        for(int i = 0; i < nums.Length; i ++)
        {
            int sum = nums[i];
            if( i + (k -1 ) >= nums.Length)
            {
                break;
            }
            for(int j = i + 1; j< i + k; j++)
            {
               
                sum+=nums[j];

            }

               max = Math.Max(max, sum); 

        }
        double result = (double)max / k;
        Math.Round(result, 2);
        return result;
    }
}