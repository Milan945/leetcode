using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays
{
    internal class Remove_Duplicates_from_Sorted_Array_2
    {
        public int RemoveDuplicates(int[] nums)
        {

            int uniqueNumbers = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                    uniqueNumbers++;
            }

            int[] newArr = new int[uniqueNumbers];
            int pos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    nums[pos] = nums[i];
                    pos++;
                }
            }

            return pos;
        }
    }
}
