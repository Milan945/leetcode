using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays
{
    internal class Valid_Mountain_Array
    {
        public bool ValidMountainArray(int[] arr)
        {
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[maxIndex] <= arr[i])
                    maxIndex = i;
            }
            if (maxIndex == 0 || maxIndex + 1 == arr.Length)
                return false;

            for (int i = 0; i < maxIndex; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    return false;
                }
            }

            for (int i = maxIndex; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
