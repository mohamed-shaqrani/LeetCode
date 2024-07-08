using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal static class LargestPerimeter
    {
        public static int LargestPerimeterss(int[] nums)//[2, 1, 2] //[1,2,1,10]/[3,6,2,3]



        {
            if (nums.Length == 0 || nums.Length < 3)
            {
                return 0;
            }
            var newnums = nums.Order().ToArray();
            int first ;
            int second;
            int third ;
            int len = newnums.Length;
            for (int i = len - 1; i > 0; i--)
            {
                if (i == len - 3 && newnums[i] == 0)
                {
                    return 0;
                }
                first = newnums[len - 1];
                second = newnums[len - 2];
                third = newnums[len - 3];
                if (first == 0 || second == 0 || third == 0)
                {
                    return 0;
                }
                if (first + second > third && second + third > first && first + third > second)
                {
                    return first + second + third;
                }
                len--;
                if (len - 1 < 2)
                {
                    return 0;
                }
                i = len;
            }
            return 0;
          
        }
        //chat gpt version
        public static int LargestPerimeterV2(int[] nums)
        {
            // If there are fewer than 3 sides, we cannot form a triangle.
            if (nums.Length < 3)
            {
                return 0;
            }

            // Sort the array in descending order
            var sortedNums = nums.OrderByDescending(x => x).ToArray();

            // Check each triplet starting from the largest
            for (int i = 0; i < sortedNums.Length - 2; i++)
            {
                int first = sortedNums[i];
                int second = sortedNums[i + 1];
                int third = sortedNums[i + 2];

                // If the sides satisfy the triangle inequality theorem, return their perimeter
                if (first < second + third)
                {
                    return first + second + third;
                }
            }

            // If no valid triangle is found, return 0
            return 0;
        }

    }
}
