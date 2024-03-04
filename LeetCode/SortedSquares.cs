using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public  class SortedSquares
    {
        public static int[] SortedSquaresInt(int[] nums)
        {
            // approach one 
           
            
            return [.. nums.ToList().Select(x => x * x).Order()];
        }
        public static int[] SortedSquaresIntV2(int[] nums)
        {
            //[-7,-3,2,3,11]
            int[] result = new int[nums.Length];

            int left = 0; int right = nums[^1];
            for (int i = nums.Length-1; i >= 0; i--)
            {
                int square;
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    square = nums[right];
                    right--;
                }
                else
                {
                    square = nums[left];
                    left--;
                }
                result[i] = square;
            }
            return result;

           
        }
    }
}
