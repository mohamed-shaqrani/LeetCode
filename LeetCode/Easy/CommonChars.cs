using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Easy
{
    internal class CommonChars
    {
//        Given a string array words, return an array of all characters
//        that show up in all strings within the words(including duplicates).
//        You may return the answer in any order.

        //Example 1:

        //Input: words = ["bella", "label", "roller"]
        //Output: ["e","l","l"]
        //Example 2:

        //Input: words = ["cool", "lock", "cook"]
        //Output: ["c","o"]
        public static IList<string> CommonCharsPro(string[] words)
        {
            Dictionary<char[],int> keyValuePairs = new Dictionary<char[],int>();
            IEnumerable<char> result = new List<char>();
            for (int i = 0; i < words.Length; i++)
            {
                keyValuePairs.Add(words[i].ToCharArray(), 1);
            }
           
           List<string> list = new List<string>();  
            foreach (char c in result)
            {
                list.Add(c.ToString());
            }
            return list;
        }
        public static IList<string> CommonCharsProV2(string[] words)
        {

            var first = words[0].ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 1; j < words[i].Length; i++)
                {
                    var result = words[j];
                }
            }
            return new List<string>();
        }
    }
}
