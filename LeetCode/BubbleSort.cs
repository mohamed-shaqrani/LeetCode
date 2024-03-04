using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BubbleSort
    {
        public static int[] Sort(int[] nums)
        {

            for (int i = nums.Length -1; i >0; i--)
            {
                //[1,5,2,6,9,10,7]
                for (int j = 0; j <i; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        int temp = nums[j + 1];
                        nums[j+1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
         

        }
    }
}
