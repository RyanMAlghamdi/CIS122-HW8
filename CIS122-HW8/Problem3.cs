//Ryan Alghamdi
//April 16

//HW8 problem 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW8
{
    public class Solution3
    {
        public int PivotIndex(int[] nums)
        {
            int total = 0, leftSum = 0;

            // Calculate total sum of the array
            foreach (var num in nums) total += num;

            // Loop through each element to find pivot index
            for (int i = 0; i < nums.Length; i++)
            {
                // Right sum is total - left sum - current number
                if (leftSum == total - leftSum - nums[i]) return i;

                // Update left sum by adding the current number
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
