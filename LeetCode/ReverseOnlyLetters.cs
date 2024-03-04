using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseOnlyLetters
    {
        public static string Reverse_OnlyLetters(string s)
        {
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length -1;
            while (left < right)
            {
                if (!char.IsLetter(chars[left]))
                    left++;
                
                else if (!char.IsLetter(chars[right]))
                    right--;
                
                else
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    right--;    
                    left++;
                }


            }
            return new string(chars);

        }

    }
}