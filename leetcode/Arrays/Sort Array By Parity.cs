using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays
{
    internal class Sort_Array_By_Parity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int oddNumberPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[oddNumberPos];
                    nums[oddNumberPos] = temp;
                    oddNumberPos++;
                }
            }
            return nums;
        }
    }
}
