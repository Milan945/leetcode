using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays
{
    internal class Move_Zeros
    {
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    int pos = i;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            pos = j;
                            break;
                        }
                    }
                    nums[i] = nums[pos];
                    nums[pos] = 0;
                }
            }
        }
    }
}
