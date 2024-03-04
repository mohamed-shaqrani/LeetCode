using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinAddToMakeValid
    {
        public static int MinAddToMake_Valid(string str)
        {
          int noOfOpen =0;
            int moves =0;
            foreach (var item in str)
            {
                if (item == '(')
                {
                    noOfOpen++;
                }
                else if (item ==')')
                {
                    if (noOfOpen == 0)
                    {
                        moves++;
                    }
                    else
                    {
                        noOfOpen--;
                    }
                }
            }
            moves += noOfOpen;
            return moves;
        }
    }
}
