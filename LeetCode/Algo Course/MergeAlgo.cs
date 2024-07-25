using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_Course
{
    internal class MergeAlgo
    {
        public static List<int>  MergSortHeleper(int[]ArrayOne, int[] ArrayTwo)//[1, 10, 50], [2, 14, 99,100]
        {
           List<int> list = new List<int>(ArrayOne.Length+ ArrayTwo.Length);
            int i = 0; int j = 0;
            while (i != ArrayOne.Length  && j!= ArrayTwo.Length)
            {
                
                if (ArrayTwo[j] > ArrayOne[i])
                {
                    list.Add(ArrayOne[i]);
                    i++;
                }
                else
                {
                    list.Add(ArrayTwo[j]);
                    j++;    
                }
            }
            if (j < ArrayTwo.Length)
            {
                for (;  j< ArrayTwo.Length; j++)
                  list.Add(ArrayTwo[j]);
                
            }
            else
            {
                for (; i < ArrayOne.Length; j++)
                  list.Add(ArrayOne[i]);
            }
            return list;
        }
        public static List<int> MergSort(int[] mainArray)
        {
            if (mainArray.Length <= 1)
            {
                return mainArray.ToList();
            }
            int mid = (int)Math.Floor((decimal)mainArray.Length / 2);
            var left = MergSort(mainArray.Take(mid).ToArray());
            var right = MergSort(mainArray.Skip(mid).ToArray());
            return MergSortHeleper(left.ToArray(), right.ToArray());

        }

    }
}
