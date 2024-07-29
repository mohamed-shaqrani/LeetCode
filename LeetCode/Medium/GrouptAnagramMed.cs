using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    internal class GrouptAnagramMed
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();
            if (strs.Length ==0)
            {
                return list;
            }
            if (strs.Length == 1)
            {
                 list.Add(new List<string> { strs[0] });
                return list;
            }
            var dic = new Dictionary<string ,IList<string>>();// ["eat","tea","tan","ate","nat","bat"]
            
            foreach (var str in strs)
            {
                string s = new string(str.Order().ToArray());
                if (dic.ContainsKey(s))
                {
                    dic[s].Add(str); 
                }
                else
                {
                    dic[s] = new List<string>
                {
                    str,
                };
                }

            }
            foreach (var item in dic.Values)
            {
                list.Add((List<string>)item);
            }
            int z = 0;
            return list;
        }
    }
}
