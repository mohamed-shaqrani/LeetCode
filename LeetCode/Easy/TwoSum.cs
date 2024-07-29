using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class TwoSum
    {
        
        //public int[] FindTwoSum(int[] nums, int target)
        //{
        //    var dic = new Dictionary<int,int>();
        //    foreach (int i in nums)
        //    {
        //        dic.Add(i, 1);

        //    }
        //    var res = dic.Select(x=>x).Any(x => dic.Where(k => k.Key != x.Key).Any(s => s.Key + x.Key == target));
        //    if (dic.Any(x=> dic.Where(k=>k.Key != x.Key).Any(s=>s.Key + x.Key  == target) ))
        //    {
        //        if (true)
        //        {
                    
        //        }
        //    }
        //}
        public int[] FindTwoSum(int[] nums, int target)
        {
            var result = nums
       .Select((value, index) => new { Value = value, Index = index })
       .SelectMany(x => nums
           .Select((value, index) => new { Value = value, Index = index })
           .Where(y => x.Index != y.Index && x.Value + y.Value == target)
           .Select(y => new { Index1 = x.Index, Index2 = y.Index }))
       .FirstOrDefault();

            if (result != null)
            {
                return new int[] { result.Index1, result.Index2 };
            }

            throw new ArgumentException("No two sum solution");
        }
        public int[] FindTwoSumV2(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dic.ContainsKey(complement))
                {
                    return new int[] { dic[complement], i };
                }

                // Add the current number to the dictionary
                // Check to avoid exception if the same number is used twice
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }

            // Return an empty array or throw an exception if no solution is found
            throw new ArgumentException("No two sum solution");
        }


    }
}
