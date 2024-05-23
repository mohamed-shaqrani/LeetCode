using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class IsPalindrome
    {
        public static bool IsPalindromeInt(int x)
        {
            if (x < 0)
                return false;

            int i = 0;
            int orginal = x;
            int len = x.ToString().Length;
            int[] res =new int[len];
           while (x > 0)
            {
                int rem = x % 10;
               
                res[i] = rem;
                i++;
                x /= 10;
            }

            return decimal.Parse(string.Join(string.Empty, res)) == orginal ? true : false;

        }
    }
}
