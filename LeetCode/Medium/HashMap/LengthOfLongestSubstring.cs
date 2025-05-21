using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.HashMap
{
    internal class LengthOfLongestSubstring
    {
        //public static int GetLengthOfLongestSubstring(string s)//abcabcbb
        //{
        //    var dic = new Dictionary<char, int>();
        //    List<int> list = new List<int>();
        //    int count =0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i>0 && i <s.Length-1)
        //        {
        //            if (s[i] != s[i-1] && s[i] != s[i+1])
        //            {

        //            }
        //        }
        //    }
        //    return 0;
        //}
        //public static int GetLengthOfLongestSubstring(string s)//abcabcbb
        //{
        //    if (s.Length ==0)
        //    {
        //        return 0;
        //    }
        //    Dictionary<char, int> dic = new Dictionary<char, int>();
        //    int[] list = new int[s.Length];
        //    var myList = new List<List<int>>();

        //    int count = 0;
        //    int index = 0;
        //    bool flag =false;
        //    int myint = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!dic.ContainsKey(s[i]))
        //        {
        //            count++;
        //            dic.Add(s[i],1);
        //        }
        //        else
        //        {
        //            dic.Clear();
        //            dic.Add(s[i], 1);
        //            myint++;
        //            list[index] =count;
        //            index++;
        //            count = 1;
        //            flag = true;

        //        }
        //    }
        //    return flag ? list.Max(): count;
        //}
        public static int GetLengthOfLongestSubstringV2(string s)//abcabcbb
        {
            if (s.Length == 0)
            {
                return 0;
            }
            var dic = new Dictionary<int, List<char>>();
            int[] list = new int[s.Length];
            int count = 0;
            int index = 0;
            int key = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(key))
                {


                    dic[s[i]].Add(s[i]);

                }
                else
                {
                    dic[s[i]] = new List<char> { s[i] };

                    //dic.Clear();
                    //dic.Add(s[i], 1);

                    list[index] = count;
                    index++;
                    count = 1;

                }
            }
            return list.Max();
        }

        public static int GetLengthOfLongestSubstringV3(string s)//abcabcbb //pwwkew //dvdf
        {
            if (s.Length == 0)
            {
                return 0;
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();

            int count = 0;
            int oldMax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var x = s[i];


                if (dic.ContainsKey(s[i]))
                {

                    //dic.Add(s[i], 1);
                    count = 0;
                    if (i != 0 && i != s.Length - 1)
                    {
                        if (i >= 2)
                        {
                            if (s[i] == s[i - 2])
                            {
                                i--;
                            }
                        }

                    }

                    dic.Clear();
                }
                if (!dic.ContainsKey(s[i]))
                {
                    count++;

                    dic.Add(s[i], 1);

                    //oldMax < count ? count : oldMax;
                    if (oldMax < count)
                    {
                        oldMax = count;
                    }
                }


            }
            return oldMax;


        }

        public static int GetLengthOfLongestSubstringV5(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();
            int maxLength = 0;
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                char currentChar = s[end];

                if (dic.ContainsKey(currentChar))
                {
                    // Move the start to the position right after the last occurrence
                    start = Math.Max(start, dic[currentChar] + 1);
                }

                // Update or add the character's position
                dic[currentChar] = end;

                // Calculate the length of the current substring and update the maxLength
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

    }

}
