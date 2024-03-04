using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeSortedArray
    {




        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
            {
                if (nums1.Length == 0 && nums2.Length > 0 && n > 0)
                {
                    nums1 = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        nums1[i] = nums2[i];
                    }
                    nums1 = nums1.OrderBy(x => x).ToArray();
                    return;

                }
                if (nums2.Length == 0 && nums1.Length > 0 && m > 0)
                {
                    nums2 = new int[m];
                    for (int i = 0; i < m; i++)
                    {
                        nums2[i] = nums1[i];
                    }
                    nums1 = nums2.OrderBy(x => x).ToArray();
                    return;
                }

            }
            int[] sorted = new int[m + n];
            int j = 0;
            int totalLen = (m + n) - 1;
            if (m >= n)
            {
                for (int i = 0; i < m; i++)
                {
                    sorted[i] = nums1[i];
                    sorted[totalLen] = nums2[j];
                    j++;
                    totalLen--;
                }
            }
            var arr = sorted.OrderBy(x => x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                nums1[i] = arr[i];
            }
           
            var checkLen = nums1.Length;
            return;
        }
    }
}
