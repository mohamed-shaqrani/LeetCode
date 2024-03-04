using System;
using System.Text;

namespace LeetCode
{
    public class AddToArrayForm
    {
        public static IList<int> AddToArrayFormInt(int[] nums, int k)
        {
            //            Example 1:

            //Input: num = [1, 2, 0, 0], k = 34
            //Output: [1,2,3,4]
            //Explanation: 1200 + 34 = 1234
            //Example 2:

            //Input: num = [2, 7, 4], k = 181
            //Output: [4,5,5]
            //Explanation: 274 + 181 = 455
            //Example 3:

            //Input: num = [2, 1, 5], k = 806
            //Output: [1,0,2,1]
            //Explanation: 215 + 806 = 1021
            var str = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                str.Append(nums[i]);
            }
            var convertedNum = long.Parse(str.ToString());
            var sum = convertedNum + k;

            int len = sum.ToString().Length;

            var result = new int[len];

            while (len > 0)
            {
                decimal lastNumber = sum % 10;
                sum /= 10;
                result[len - 1] = (int)lastNumber;
                len--;

            }
            var list = new List<int>(result);
            return list;
        }
        public static IList<int> AddToArrayFormIntV2(int[] nums, int k)
        {
            var result = new List<int>();
            //7, 2, 2  /142
            int carry = k;

            for (int i = nums.Length - 1; i >= 0 || carry > 0; i--)
            {
                if (i >= 0)
                {
                    carry += nums[i];
                }
                result.Add(carry % 10);
                carry /= 10;
            }

            result.Reverse(); // Reverse the result to get the correct order

            return result;
        }
    }
}
