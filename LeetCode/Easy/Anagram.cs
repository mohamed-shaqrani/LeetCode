using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class Anagram
    {
        public static bool IsAnagram(string s, string t)
        {
            int totalOne = 0;
            int totaTwo = 0;

            foreach (char c in s)
            {
                totalOne += c;
            }
            foreach (char c in t)
            {
                totaTwo += c;
            }
            return totalOne == totaTwo;
        }
        public static bool IsAnagramV2(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            StringBuilder ss = new StringBuilder();
            ss.Append(s);
            StringBuilder tt = new StringBuilder();
            tt.Append(t);
            int len = s.Length;
            for (int i = 0; i < tt.Length; i++)
            {
               for (int j = 0; j < ss.Length; j++)//rac car
                {
                    if (len<=0)
                    {
                        return true;
                    }
                    if (tt[i] == ss[j])
                    {
                        len--;
                        ss.Remove(j, 1);
                    }
                }
            }
            return len == 0;
        }
        public static bool IsAnagramV3(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            } 
            return !s.ToHashSet().Any(x => !t.ToHashSet().Any(y => y == x));
        }
        public static bool IsAnagramV4(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
          
            return s.Order().SequenceEqual(t.Order());  

        }
        public static bool IsAnagramV5(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var dic = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item]++;
                }
            }
            foreach (var item in t)
            {
                if (!dic.ContainsKey(item))
                {
                    return false ;
                }
                dic[item]--;
                if (dic[item] <0)
                {
                    return false;
                }
            }

            return false;

        }

    }
}
